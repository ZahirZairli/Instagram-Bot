using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramTutorial
{
   public class Sql
    {
        public static DataTable Exec(string sorgu)
        {
            string connectionstring = @"Data Source=DESKTOP-SDVG61S\SQLEXPRESS;Initial Catalog=ınsta; Persist Security Info=True;";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            SqlCommand srg = new SqlCommand(sorgu, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(srg);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlcon.Close();
            return dt;
        }
    }
}
