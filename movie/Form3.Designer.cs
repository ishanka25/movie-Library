namespace movie_lib
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_watched = new System.Windows.Forms.CheckBox();
            this.cmb_Gener = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_imdbid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ov = new System.Windows.Forms.TextBox();
            this.txt_Rating = new System.Windows.Forms.TextBox();
            this.txt_Rt = new System.Windows.Forms.TextBox();
            this.dtp_Release = new System.Windows.Forms.DateTimePicker();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Watched = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataSet = new movie_lib.movieDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.watchedTableAdapter = new movie_lib.movieDataSetTableAdapters.watchedTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Delete);
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
            this.groupBox3.Location = new System.Drawing.Point(243, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 293);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // chk_watched
            // 
            this.chk_watched.AutoSize = true;
            this.chk_watched.Location = new System.Drawing.Point(406, 105);
            this.chk_watched.Name = "chk_watched";
            this.chk_watched.Size = new System.Drawing.Size(94, 17);
            this.chk_watched.TabIndex = 21;
            this.chk_watched.Text = "Wish to watch";
            this.chk_watched.UseVisualStyleBackColor = true;
            // 
            // cmb_Gener
            // 
            this.cmb_Gener.FormattingEnabled = true;
            this.cmb_Gener.Location = new System.Drawing.Point(379, 63);
            this.cmb_Gener.Name = "cmb_Gener";
            this.cmb_Gener.Size = new System.Drawing.Size(121, 21);
            this.cmb_Gener.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gener";
            // 
            // txt_imdbid
            // 
            this.txt_imdbid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_imdbid.Location = new System.Drawing.Point(91, 106);
            this.txt_imdbid.Name = "txt_imdbid";
            this.txt_imdbid.ReadOnly = true;
            this.txt_imdbid.Size = new System.Drawing.Size(132, 20);
            this.txt_imdbid.TabIndex = 18;
            this.txt_imdbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Overview";
            // 
            // txt_ov
            // 
            this.txt_ov.Location = new System.Drawing.Point(91, 175);
            this.txt_ov.MaxLength = 2000;
            this.txt_ov.Multiline = true;
            this.txt_ov.Name = "txt_ov";
            this.txt_ov.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ov.Size = new System.Drawing.Size(230, 105);
            this.txt_ov.TabIndex = 15;
            // 
            // txt_Rating
            // 
            this.txt_Rating.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Rating.Location = new System.Drawing.Point(91, 71);
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.ReadOnly = true;
            this.txt_Rating.Size = new System.Drawing.Size(132, 20);
            this.txt_Rating.TabIndex = 14;
            // 
            // txt_Rt
            // 
            this.txt_Rt.BackColor = System.Drawing.Color.White;
            this.txt_Rt.Location = new System.Drawing.Point(91, 138);
            this.txt_Rt.Name = "txt_Rt";
            this.txt_Rt.Size = new System.Drawing.Size(132, 20);
            this.txt_Rt.TabIndex = 14;
            this.txt_Rt.TabStop = false;
            this.txt_Rt.Text = "00 mins";
            this.txt_Rt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Rt.WordWrap = false;
            // 
            // dtp_Release
            // 
            this.dtp_Release.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Release.Location = new System.Drawing.Point(379, 31);
            this.dtp_Release.Name = "dtp_Release";
            this.dtp_Release.Size = new System.Drawing.Size(121, 20);
            this.dtp_Release.TabIndex = 13;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(91, 34);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(132, 20);
            this.txt_Title.TabIndex = 12;
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
            this.label2.Location = new System.Drawing.Point(301, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Release Date";
            // 
            // btn_Watched
            // 
            this.btn_Watched.Location = new System.Drawing.Point(397, 138);
            this.btn_Watched.Name = "btn_Watched";
            this.btn_Watched.Size = new System.Drawing.Size(103, 36);
            this.btn_Watched.TabIndex = 14;
            this.btn_Watched.Text = "Update Library";
            this.btn_Watched.UseVisualStyleBackColor = true;
            this.btn_Watched.Click += new System.EventHandler(this.btn_Watched_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 339);
            this.groupBox2.TabIndex = 14;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 275);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.imdbidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.generDataGridViewTextBoxColumn,
            this.releaseddateDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.ratingsDataGridViewTextBoxColumn,
            this.plotDataGridViewTextBoxColumn,
            this.wish,
            this.poster});
            this.dataGridView1.DataSource = this.watchedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
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
            // generDataGridViewTextBoxColumn
            // 
            this.generDataGridViewTextBoxColumn.DataPropertyName = "gener";
            this.generDataGridViewTextBoxColumn.HeaderText = "Gener";
            this.generDataGridViewTextBoxColumn.Name = "generDataGridViewTextBoxColumn";
            this.generDataGridViewTextBoxColumn.ReadOnly = true;
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
            // wish
            // 
            this.wish.DataPropertyName = "wish";
            this.wish.HeaderText = "wish";
            this.wish.Name = "wish";
            this.wish.ReadOnly = true;
            this.wish.Visible = false;
            // 
            // poster
            // 
            this.poster.DataPropertyName = "poster";
            this.poster.HeaderText = "poster";
            this.poster.Name = "poster";
            this.poster.ReadOnly = true;
            this.poster.Visible = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Location = new System.Drawing.Point(408, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(66, 24);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(188, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(397, 192);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 36);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // watchedTableAdapter
            // 
            this.watchedTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.Text = "Edit Library";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_watched;
        private System.Windows.Forms.ComboBox cmb_Gener;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_imdbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Watched;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ov;
        private System.Windows.Forms.TextBox txt_Rating;
        private System.Windows.Forms.TextBox txt_Rt;
        private System.Windows.Forms.DateTimePicker dtp_Release;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private movieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource watchedBindingSource;
        private movieDataSetTableAdapters.watchedTableAdapter watchedTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wish;
        private System.Windows.Forms.DataGridViewTextBoxColumn poster;
    }
}