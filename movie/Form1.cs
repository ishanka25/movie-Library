using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.General;
using TMDbLib.Utilities;
using TMDbLib.Objects.People;
using TMDbLib.Objects.Genres;
using movie_lib.DBConnection;
using System.Net;

namespace movie_lib
{
    public partial class Form1 : Form
    {
        DB_Con dbcon = new DB_Con();

        public TMDbClient client = new TMDbClient("10e40e83fc309070afd75e60130ec91d");
        public string listBoxMovieID;
        public string[] geners = new string[] { "Action", "Adventure","Comedy","Crime","Drama","Horror","Epic","Sci-Fi","Musical","Love Story"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a movie title to search.");                
            }
            else
            {
                try
                {
                    SearchContainer<SearchMovie> results = client.SearchMovie(textBox1.Text);

                    listBox1.Items.Clear();
                    listBox2.Items.Clear();

                    foreach (SearchMovie result in results.Results)
                    {
                        listBox1.Items.Add(result.Title);
                        listBox2.Items.Add(result.Id);
                    }
                    button2.Enabled = true;

                    if (listBox1.Items.Count == 0)
                    {
                        MessageBox.Show("Sorry, no movies were found.");
                        button2.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No Internet Connection to IMDB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button2.Enabled = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBoxMovieID = listBox2.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = client.GetMovie(Convert.ToInt32(listBoxMovieID), MovieMethods.Trailers);
            
            txt_Title.Text = movie.OriginalTitle.ToString();
            pictureBox1.ImageLocation = "https://image.tmdb.org/t/p/w185" + movie.PosterPath;
            dtp_Release.Value = movie.ReleaseDate.Value;
            txt_Rt.Text = movie.Runtime.ToString() + " mins";
            txt_Rating.Text = movie.VoteAverage.ToString() + "/10";
            txt_ov.Text = movie.Overview;
            txt_imdbid.Text = movie.ImdbId;
        }

        private void btn_Watched_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_Title.Text;
                DateTime rd = dtp_Release.Value.Date;
                string imdbid = txt_imdbid.Text;
                string rate = txt_Rating.Text;
                String ovw = Convert.ToString( txt_ov.Text);
                string rt = txt_Rt.Text;
                string gnr = cmb_Gener.SelectedItem.ToString();
                string poster_path = System.IO.Directory.GetCurrentDirectory() + @"\image\" + txt_Title.Text + @".jpg";
                string wish = "no";

                if(chk_watched.Checked==true)
                {
                    wish = "yes";
                }

                if (pictureBox1.ImageLocation == "")
                {

                }
                else
                {
                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(pictureBox1.ImageLocation.ToString(), poster_path);
                        }
                    }
                    catch(Exception)
                    {
                        pictureBox1.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\image\noposter.jpg";
                    }
                }

                int noline = dbcon.save(imdbid,name,rd,rt,rate,ovw,gnr,poster_path,wish);

                if(noline>0)
                {
                    MessageBox.Show("Movie added to the library");
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "The remote server returned an error: (400) Bad Request.")
                {
                    pictureBox1.ImageLocation = "";

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dbcon.CloseCon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Gener.Items.Clear();

            foreach (string g in geners)
            {
                cmb_Gener.Items.Add(g);
            }
            cmb_Gener.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}

