using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.ProviderBase;

namespace movie_lib.DBConnection
{
        public class DB_Con
        {
            public string constring;
            public SqlCommand com = null;
            public SqlConnection con = null;

            public DB_Con()
            {
                Connection_Sql();
            }

            public void Connection_Sql()
            {
                constring=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ishanka Ranatunga\Documents\Visual Studio 2013\Projects\movie\movie\movie.mdf;Integrated Security=True;Connect Timeout=30";
                
                con = new SqlConnection(constring);
            }

            public void OpenCon()
            {
                con.Open();
            }

            public void CloseCon()
            {
                con.Close();
            }
            
            public int save_del_update(String query)
            {
                OpenCon();
                int line = 0;
                com = new SqlCommand(query, con);
                line = com.ExecuteNonQuery();
                com.Dispose();
                CloseCon();
                return line;
            }

            public int save(string imdb,string name,DateTime rd,string rt,string rate,string plot,string gen,string pos,string wish)
            {
                OpenCon();
                int line = 0;

                com = new SqlCommand("insert into watched(imdb_id,title,released_date,runtime,ratings,plot,gener,poster,wish) values(@imdb,@name,@rd,@rt,@rate,@plot,@gen,@pos,@wish)", con);

                com.Parameters.Add(new SqlParameter("@imdb", imdb));
                com.Parameters.Add(new SqlParameter("@name", name));
                com.Parameters.Add(new SqlParameter("@rd", rd));
                com.Parameters.Add(new SqlParameter("@rt", rt));
                com.Parameters.Add(new SqlParameter("@rate", rate));
                com.Parameters.Add(new SqlParameter("@plot", plot));
                com.Parameters.Add(new SqlParameter("@gen", gen));
                com.Parameters.Add(new SqlParameter("@pos", pos));
                com.Parameters.Add(new SqlParameter("@wish", wish));

                line=com.ExecuteNonQuery();

                return line;
            }

            public SqlDataReader data_reader(string query)
            {
                SqlDataReader dr;
                OpenCon();
                com = new SqlCommand(query, con);
                dr = com.ExecuteReader();
                com.Dispose();
                CloseCon();
                return dr;
            }

            public DataTable selecting_data(string query)
            {
                DataTable dt = new DataTable();
                OpenCon();
                com = new SqlCommand(query, con);
                dt.Load(com.ExecuteReader());
                com.Dispose();
                CloseCon();
                return dt;
            }

            public DataTable data_table(string query)
            {
                OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CloseCon();
                return dt;
            }

            public int update(string imdb, string name, DateTime rd, string rt, string rate, string plot, string gen, string pos, string wish,string whre)
            {
                OpenCon();
                int line = 0;

                com = new SqlCommand("update watched set imdb_id=@imdb,title=@name,released_date=@rd,runtime=@rt,ratings=@rate,plot=@plot,gener=@gen,poster=@pos,wish=@wish where Id=@whre", con);

                com.Parameters.Add(new SqlParameter("@imdb", imdb));
                com.Parameters.Add(new SqlParameter("@name", name));
                com.Parameters.Add(new SqlParameter("@rd", rd));
                com.Parameters.Add(new SqlParameter("@rt", rt));
                com.Parameters.Add(new SqlParameter("@rate", rate));
                com.Parameters.Add(new SqlParameter("@plot", plot));
                com.Parameters.Add(new SqlParameter("@gen", gen));
                com.Parameters.Add(new SqlParameter("@pos", pos));
                com.Parameters.Add(new SqlParameter("@wish", wish));
                com.Parameters.Add(new SqlParameter("@whre", whre));

                line = com.ExecuteNonQuery();

                return line;
            }

        }    
}
