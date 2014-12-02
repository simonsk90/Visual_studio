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
            string query = "INSERT INTO ScrumActivity (title, description, tags) VALUES (@title, @description, 'TAG')";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@title", a.title);
            cmd.Parameters.AddWithValue("@description", a.description);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Activity getActivityByID(int aID)
        {
            Activity a = new Activity();
            string query = "SELECT * FROM ScrumActivity WHERE ID = " + aID;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();      

            while (dr.Read())
            {
                a = new Activity(Convert.ToInt32(dr["ID"]), dr["title"].ToString(),
                dr["description"].ToString(), dr["tags"].ToString());
                Console.WriteLine(a.title);
            }
            return a;        
        }

        public List<Activity> getAllActivities()
        {
            List<Activity> allActivities = new List<Activity>();
            string query = "SELECT * FROM ScrumActivity";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.HasRows)
            {
                Activity a = new Activity(Convert.ToInt32(dr["ID"]), dr["title"].ToString(),
                dr["description"].ToString(), dr["tags"].ToString());         
                allActivities.Add(a);
            }
            return allActivities;
        }
    }
}