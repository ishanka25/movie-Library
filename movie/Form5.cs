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
    public partial class Form5 : Form
    {
        DB_Con dbcon3 = new DB_Con();
        private Form1 f1 = null;
        private Form3 f2 = null;
        private Form4 f3 = null;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet.watched' table. You can move, or remove it, as needed.
            this.watchedTableAdapter.Fill(this.movieDataSet.watched);
            refreshGrid();
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
                dt = dbcon3.data_table(query1);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_imdbid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txt_Title.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            dtp_Release.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value).ToShortDateString();
            txt_Rt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txt_Rating.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txt_ov.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txt_Gener.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            pictureBox1.ImageLocation = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            if(Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value)=="yes")
            {
                txt_Watched.Text = "No";
            }
            else
            {
                txt_Watched.Text = "Yes";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                //MessageBox.Show("Enter a Title to Search");
                string s = txt_Search.Text;
                string query = "select * from watched";

                LoadGrid(dbcon3.selecting_data(query));
            }
            else
            {
                string s = txt_Search.Text;
                string query = "select * from watched where title like'%" + s + "%'";

                LoadGrid(dbcon3.selecting_data(query));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2 = new Form3();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f3 = new Form4();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
