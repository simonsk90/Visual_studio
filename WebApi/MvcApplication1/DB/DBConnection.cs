using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;

namespace MvcApplication1.DB
{
    public class DBConnection
    {
        //here we put our connectionstring from our app.config in a string
        private string connectionString = "server=balder.ucn.dk;database=dmaa0213_4;User id=dmaa0213_4;Password=MaaGodt";

        //method to open connection for our SQL
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            finally
            {
                //Console.WriteLine("FAIL! ikke forbindelse");
            }

            return connection;
        }

    }
}