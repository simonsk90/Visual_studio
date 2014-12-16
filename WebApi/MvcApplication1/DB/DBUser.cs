using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.DB
{
    public class DBUser : Controller
    {
        DBConnection dbc = new DBConnection();
        //
        // GET: /DBUser/

        public void addUser(User u)
        {
            string query = "INSERT INTO ScrumUsers (fName, lName, birthday, email, password, ranking) VALUES (@fName, @lName, @birthday, @email, @password, @ranking)";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            string bday = u.birthday.ToString();

            cmd.Parameters.AddWithValue("@fName", u.fName);
            cmd.Parameters.AddWithValue("@lName", u.lName);
            cmd.Parameters.AddWithValue("@birthday", bday);
            cmd.Parameters.AddWithValue("@email", u.email);
            cmd.Parameters.AddWithValue("@password", u.password);
            cmd.Parameters.AddWithValue("@ranking", u.ranking);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public User getUserByName(string username, string password)
        {
            User u = new User();
            string query = "SELECT * FROM ScrumUsers WHERE email = " + username + " AND password = " + password;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                u = new User(Convert.ToInt32(dr["ID"]), dr["fName"].ToString(),
                dr["lName"].ToString(), Convert.ToDateTime(dr["birthday"]), dr["email"].ToString(),
                dr["password"].ToString(), Convert.ToInt32(dr["ranking"]));
            }
            return u;
        }

    }
}
