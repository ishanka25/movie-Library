namespace movie_lib
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imdbidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataSet = new movie_lib.movieDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Watched = new System.Windows.Forms.Label();
            this.txt_Gener = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_Release = new System.Windows.Forms.Label();
            this.txt_ov = new System.Windows.Forms.Label();
            this.txt_Rt = new System.Windows.Forms.Label();
            this.txt_imdbid = new System.Windows.Forms.Label();
            this.txt_Rating = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.watchedTableAdapter = new movie_lib.movieDataSetTableAdapters.watchedTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Location = new System.Drawing.Point(408, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 40);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(66, 15);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(188, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imdbidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.releaseddateDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.ratingsDataGridViewTextBoxColumn,
            this.plotDataGridViewTextBoxColumn,
            this.generDataGridViewTextBoxColumn,
            this.posterDataGridViewTextBoxColumn,
            this.wishDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.watchedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // imdbidDataGridViewTextBoxColumn
            // 
            this.imdbidDataGridViewTextBoxColumn.DataPropertyName = "imdb_id";
            this.imdbidDataGridViewTextBoxColumn.HeaderText = "IMDB ID";
            this.imdbidDataGridViewTextBoxColumn.Name = "imdbidDataGridViewTextBoxColumn";
            this.imdbidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseddateDataGridViewTextBoxColumn
            // 
            this.releaseddateDataGridViewTextBoxColumn.DataPropertyName = "released_date";
            this.releaseddateDataGridViewTextBoxColumn.HeaderText = "Released On";
            this.releaseddateDataGridViewTextBoxColumn.Name = "releaseddateDataGridViewTextBoxColumn";
            this.releaseddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            this.runtimeDataGridViewTextBoxColumn.DataPropertyName = "runtime";
            this.runtimeDataGridViewTextBoxColumn.HeaderText = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            this.runtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingsDataGridViewTextBoxColumn
            // 
            this.ratingsDataGridViewTextBoxColumn.DataPropertyName = "ratings";
            this.ratingsDataGridViewTextBoxColumn.HeaderText = "Ratings";
            this.ratingsDataGridViewTextBoxColumn.Name = "ratingsDataGridViewTextBoxColumn";
            this.ratingsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plotDataGridViewTextBoxColumn
            // 
            this.plotDataGridViewTextBoxColumn.DataPropertyName = "plot";
            this.plotDataGridViewTextBoxColumn.HeaderText = "Overview";
            this.plotDataGridViewTextBoxColumn.Name = "plotDataGridViewTextBoxColumn";
            this.plotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generDataGridViewTextBoxColumn
            // 
            this.generDataGridViewTextBoxColumn.DataPropertyName = "gener";
            this.generDataGridViewTextBoxColumn.HeaderText = "Gener";
            this.generDataGridViewTextBoxColumn.Name = "generDataGridViewTextBoxColumn";
            this.generDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterDataGridViewTextBoxColumn
            // 
            this.posterDataGridViewTextBoxColumn.DataPropertyName = "poster";
            this.posterDataGridViewTextBoxColumn.HeaderText = "poster";
            this.posterDataGridViewTextBoxColumn.Name = "posterDataGridViewTextBoxColumn";
            this.posterDataGridViewTextBoxColumn.ReadOnly = true;
            this.posterDataGridViewTextBoxColumn.Visible = false;
            // 
            // wishDataGridViewTextBoxColumn
            // 
            this.wishDataGridViewTextBoxColumn.DataPropertyName = "wish";
            this.wishDataGridViewTextBoxColumn.HeaderText = "wish";
            this.wishDataGridViewTextBoxColumn.Name = "wishDataGridViewTextBoxColumn";
            this.wishDataGridViewTextBoxColumn.ReadOnly = true;
            this.wishDataGridViewTextBoxColumn.Visible = false;
            // 
            // watchedBindingSource
            // 
            this.watchedBindingSource.DataMember = "watched";
            this.watchedBindingSource.DataSource = this.movieDataSet;
            // 
            // movieDataSet
            // 
            this.movieDataSet.DataSetName = "movieDataSet";
            this.movieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Watched);
            this.groupBox3.Controls.Add(this.txt_Gener);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtp_Release);
            this.groupBox3.Controls.Add(this.txt_ov);
            this.groupBox3.Controls.Add(this.txt_Rt);
            this.groupBox3.Controls.Add(this.txt_imdbid);
            this.groupBox3.Controls.Add(this.txt_Rating);
            this.groupBox3.Controls.Add(this.txt_Title);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(230, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 304);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // txt_Watched
            // 
            this.txt_Watched.AutoSize = true;
            this.txt_Watched.Location = new System.Drawing.Point(368, 106);
            this.txt_Watched.Name = "txt_Watched";
            this.txt_Watched.Size = new System.Drawing.Size(0, 13);
            this.txt_Watched.TabIndex = 4;
            // 
            // txt_Gener
            // 
            this.txt_Gener.AutoSize = true;
            this.txt_Gener.Location = new System.Drawing.Point(368, 65);
            this.txt_Gener.Name = "txt_Gener";
            this.txt_Gener.Size = new System.Drawing.Size(0, 13);
            this.txt_Gener.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Watched";
            // 
            // dtp_Release
            // 
            this.dtp_Release.AutoSize = true;
            this.dtp_Release.Location = new System.Drawing.Point(368, 34);
            this.dtp_Release.Name = "dtp_Release";
            this.dtp_Release.Size = new System.Drawing.Size(0, 13);
            this.dtp_Release.TabIndex = 25;
            // 
            // txt_ov
            // 
            this.txt_ov.AutoEllipsis = true;
            this.txt_ov.Location = new System.Drawing.Point(112, 174);
            this.txt_ov.Name = "txt_ov";
            this.txt_ov.Size = new System.Drawing.Size(401, 117);
            this.txt_ov.TabIndex = 24;
            // 
            // txt_Rt
            // 
            this.txt_Rt.AutoSize = true;
            this.txt_Rt.Location = new System.Drawing.Point(111, 140);
            this.txt_Rt.Name = "txt_Rt";
            this.txt_Rt.Size = new System.Drawing.Size(0, 13);
            this.txt_Rt.TabIndex = 23;
            // 
            // txt_imdbid
            // 
            this.txt_imdbid.AutoSize = true;
            this.txt_imdbid.Location = new System.Drawing.Point(111, 106);
            this.txt_imdbid.Name = "txt_imdbid";
            this.txt_imdbid.Size = new System.Drawing.Size(0, 13);
            this.txt_imdbid.TabIndex = 22;
            // 
            // txt_Rating
            // 
            this.txt_Rating.AutoSize = true;
            this.txt_Rating.Location = new System.Drawing.Point(111, 71);
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.Size = new System.Drawing.Size(0, 13);
            this.txt_Rating.TabIndex = 21;
            // 
            // txt_Title
            // 
            this.txt_Title.AutoSize = true;
            this.txt_Title.Location = new System.Drawing.Point(111, 34);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(0, 13);
            this.txt_Title.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gener";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "IMDB ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Overview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Run Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Release Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 308);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poster";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::movie_lib.Properties.Resources.noposter;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 275);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // watchedTableAdapter
            // 
            this.watchedTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Edit Library";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 24;
            this.button4.Text = "Wishlist";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(326, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 543);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form5";
            this.Text = "Movie Library";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_Gener;
        private System.Windows.Forms.Label dtp_Release;
        private System.Windows.Forms.Label txt_ov;
        private System.Windows.Forms.Label txt_Rt;
        private System.Windows.Forms.Label txt_imdbid;
        private System.Windows.Forms.Label txt_Rating;
        private System.Windows.Forms.Label txt_Title;
        private movieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource watchedBindingSource;
        private movieDataSetTableAdapters.watchedTableAdapter watchedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txt_Watched;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
    }
}