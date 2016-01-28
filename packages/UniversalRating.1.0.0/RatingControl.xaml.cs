using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Ulixes.UserControls
{
    public sealed partial class RatingControl : UserControl, System.ComponentModel.INotifyPropertyChanged
    {
        public int MaxRating
        {
            get { return (int)GetValue(MaxRatingProperty); }
            set
            {
                SetValue(MaxRatingProperty, value);
                for (int i = 0; i < value; i++)
                    BackgroundStarsTextBlock.Text += RatingCharacter;

                ForegroundStarsTextBlock.Text = BackgroundStarsTextBlock.Text;
            }
        }

        public static readonly DependencyProperty MaxRatingProperty = DependencyProperty.Register("MaxRating", typeof(int), typeof(RatingControl), new PropertyMetadata(5));

        public double Rating
        {
            get { return (double)GetValue(RatingProperty); }
            set
            {
                SetValue(RatingProperty, value);
            }
        }

        public static readonly DependencyProperty RatingProperty = DependencyProperty.Register("Rating", typeof(double), typeof(RatingControl), new PropertyMetadata(0));

        public char RatingCharacter
        {
            get { return (char)GetValue(RatingCharacterProperty); }
            set
            {
                SetValue(RatingCharacterProperty, value);
                OnPropertyChanged(() => MaxRating);
            }
        }

        public static readonly DependencyProperty RatingCharacterProperty = DependencyProperty.Register("RatingCharacter", typeof(char), typeof(RatingControl), new PropertyMetadata('★'));

        public SolidColorBrush StarsBackground
        {
            get { return (SolidColorBrush)GetValue(StarsBackgroundProperty); }
            set { SetValue(StarsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty StarsBackgroundProperty = DependencyProperty.Register("StarsBackground", typeof(SolidColorBrush), typeof(RatingControl), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public SolidColorBrush StarsForeground
        {
            get { return (SolidColorBrush)GetValue(StarsForegroundProperty); }
            set { SetValue(StarsForegroundProperty, value); }
        }

        public static readonly DependencyProperty StarsForegroundProperty = DependencyProperty.Register("StarsForeground", typeof(SolidColorBrush), typeof(RatingControl), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(int), typeof(RatingControl), new PropertyMetadata(24));

        public RatingControl()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        #region INotifyPropertyChanged IMPLEMENTATION
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnPropertyChanged<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);
            string name = body.Member.Name;
            OnPropertyChanged(name);
        }
        #endregion

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ForegroundStarsTextBlock.Width = BackgroundStarsTextBlock.ActualWidth / MaxRating * Rating;
        }
    }
}
