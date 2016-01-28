namespace movie_lib
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_scount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_watched = new System.Windows.Forms.CheckBox();
            this.cmb_Gener = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_imdbid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Watched = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ov = new System.Windows.Forms.TextBox();
            this.txt_Rating = new System.Windows.Forms.TextBox();
            this.txt_Rt = new System.Windows.Forms.TextBox();
            this.dtp_Release = new System.Windows.Forms.DateTimePicker();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Release Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_scount);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 332);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search IMDB";
            // 
            // l_scount
            // 
            this.l_scount.AutoSize = true;
            this.l_scount.Location = new System.Drawing.Point(12, 50);
            this.l_scount.Name = "l_scount";
            this.l_scount.Size = new System.Drawing.Size(0, 13);
            this.l_scount.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 212);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(154, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Get Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(15, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(214, 121);
            this.listBox2.TabIndex = 9;
            this.listBox2.TabStop = false;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 332);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poster";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 275);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_watched);
            this.groupBox3.Controls.Add(this.cmb_Gener);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_imdbid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_Watched);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_ov);
            this.groupBox3.Controls.Add(this.txt_Rating);
            this.groupBox3.Controls.Add(this.txt_Rt);
            this.groupBox3.Controls.Add(this.dtp_Release);
            this.groupBox3.Controls.Add(this.txt_Title);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(483, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 332);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // chk_watched
            // 
            this.chk_watched.AutoSize = true;
            this.chk_watched.Location = new System.Drawing.Point(250, 232);
            this.chk_watched.Name = "chk_watched";
            this.chk_watched.Size = new System.Drawing.Size(94, 17);
            this.chk_watched.TabIndex = 21;
            this.chk_watched.Text = "Wish to watch";
            this.toolTip1.SetToolTip(this.chk_watched, "Check if you haven\'t watched it yet");
            this.chk_watched.UseVisualStyleBackColor = true;
            // 
            // cmb_Gener
            // 
            this.cmb_Gener.FormattingEnabled = true;
            this.cmb_Gener.Location = new System.Drawing.Point(84, 230);
            this.cmb_Gener.Name = "cmb_Gener";
            this.cmb_Gener.Size = new System.Drawing.Size(121, 21);
            this.cmb_Gener.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gener";
            // 
            // txt_imdbid
            // 
            this.txt_imdbid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_imdbid.Location = new System.Drawing.Point(84, 52);
            this.txt_imdbid.Name = "txt_imdbid";
            this.txt_imdbid.ReadOnly = true;
            this.txt_imdbid.Size = new System.Drawing.Size(62, 20);
            this.txt_imdbid.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "IMDB ID";
            // 
            // btn_Watched
            // 
            this.btn_Watched.Location = new System.Drawing.Point(241, 290);
            this.btn_Watched.Name = "btn_Watched";
            this.btn_Watched.Size = new System.Drawing.Size(103, 31);
            this.btn_Watched.TabIndex = 14;
            this.btn_Watched.Text = "Add to Library";
            this.btn_Watched.UseVisualStyleBackColor = true;
            this.btn_Watched.Click += new System.EventHandler(this.btn_Watched_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Overview";
            // 
            // txt_ov
            // 
            this.txt_ov.Location = new System.Drawing.Point(84, 128);
            this.txt_ov.MaxLength = 2000;
            this.txt_ov.Multiline = true;
            this.txt_ov.Name = "txt_ov";
            this.txt_ov.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ov.Size = new System.Drawing.Size(260, 86);
            this.txt_ov.TabIndex = 15;
            // 
            // txt_Rating
            // 
            this.txt_Rating.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Rating.Location = new System.Drawing.Point(84, 91);
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.ReadOnly = true;
            this.txt_Rating.Size = new System.Drawing.Size(95, 20);
            this.txt_Rating.TabIndex = 14;
            // 
            // txt_Rt
            // 
            this.txt_Rt.BackColor = System.Drawing.Color.White;
            this.txt_Rt.Location = new System.Drawing.Point(294, 91);
            this.txt_Rt.Name = "txt_Rt";
            this.txt_Rt.Size = new System.Drawing.Size(50, 20);
            this.txt_Rt.TabIndex = 14;
            this.txt_Rt.TabStop = false;
            this.txt_Rt.Text = "00 mins";
            this.txt_Rt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Rt.WordWrap = false;
            // 
            // dtp_Release
            // 
            this.dtp_Release.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Release.Location = new System.Drawing.Point(249, 52);
            this.dtp_Release.Name = "dtp_Release";
            this.dtp_Release.Size = new System.Drawing.Size(95, 20);
            this.dtp_Release.TabIndex = 13;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(84, 19);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(260, 20);
            this.txt_Title.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Running Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 356);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.DateTimePicker dtp_Release;
        private System.Windows.Forms.TextBox txt_Rt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Rating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ov;
        private System.Windows.Forms.Button btn_Watched;
        private System.Windows.Forms.TextBox txt_imdbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_scount;
        private System.Windows.Forms.ComboBox cmb_Gener;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chk_watched;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

