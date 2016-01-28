using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using movie_lib.DBConnection;
using System.Net;

namespace movie_lib
{
    public partial class Form3 : Form
    {
        DB_Con dbcon2 = new DB_Con();

        public string[] geners = new string[] { "Action", "Adventure", "Comedy", "Crime", "Drama", "Horror", "Epic", "Sci-Fi", "Musical", "Love Story" };
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet.watched' table. You can move, or remove it, as needed.
            this.watchedTableAdapter.Fill(this.movieDataSet.watched);
            refreshGrid();
            cmb_Gener.DataSource = geners;
        }

        public void LoadGrid(DataTable data)
        {
            DataTable dt1 = new DataTable();
            dt1 = data;
            dataGridView1.DataSource = dt1;
        }

        public void refreshGrid()
        {
            try
            {
                string query1 = "select * from watched";

                DataTable dt = new DataTable();
                dt = dbcon2.data_table(query1);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Watched_Click(object sender, EventArgs e)
        {
            try
            {
                string where;

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
                else{}

                if (pictureBox1.ImageLocation == "")
                {

                }
                else if (pictureBox1.ImageLocation == Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value))
                {
                    pictureBox1.ImageLocation = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                }
                else
                {

                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(pictureBox1.ImageLocation.ToString(), poster_path);
                    }
                }

                where = Convert.ToString( dataGridView1.CurrentRow.Cells[0].Value );

                int noline = dbcon2.update(imdbid,name,rd,rt,rate,ovw,gnr,poster_path,wish,where);

                if(noline>0)
                {
                    MessageBox.Show("Movie Details Updated!");
                }
                else
                {
                    MessageBox.Show("Update Error");
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
            dbcon2.CloseCon();
            refreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text=="")
            {
                //MessageBox.Show("Enter a Title to Search");
                string s = txt_Search.Text;
                string query = "select * from watched";

                LoadGrid(dbcon2.selecting_data(query));
            }
            else
            {
                string s = txt_Search.Text;
                string query="select * from watched where title like'%"+s+"%'";

                LoadGrid( dbcon2.selecting_data(query) );
            }            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int line = 0;

            DialogResult dr = MessageBox.Show("Do you want to remove the selected movie?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dr.ToString()=="Yes")
            {
                int indx=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string query = "delete from watched where id='" + indx + "'";

                line = dbcon2.save_del_update(query);

                if (line > 0)
                {
                    refreshGrid();
                    MessageBox.Show("Movie Removed Successfuly");
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_imdbid.Text= Convert.ToString( dataGridView1.CurrentRow.Cells[1].Value);
            txt_Title.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            dtp_Release.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            txt_Rt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txt_Rating.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            txt_ov.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            cmb_Gener.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            pictureBox1.ImageLocation = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
        }
    }
}
