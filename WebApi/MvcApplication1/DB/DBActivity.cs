using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.DB
{
    public class DBActivity
    {
        DBConnection dbc = new DBConnection();

        public void addActivity(Activity a)
        {
            string query = "INSERT INTO ScrumActivity (title, description, tags) VALUES (@title, @description, 'HEJ')";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@title", a.title);
            cmd.Parameters.AddWithValue("@description", a.description);
           // cmd.Parameters.AddWithValue("@Tags", "din mor er fed");

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }




    }
}