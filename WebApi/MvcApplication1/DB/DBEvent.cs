using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.DB
{
    public class DBEvent
    {
        DBConnection dbc = new DBConnection();

        public void addEvent(Event e)
        {
            string query = "INSERT INTO ScrumEvent (date, lecture, activityID, locationID) VALUES (@date, @lecture, @activityID, @locationID)";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@date", e.date);
            cmd.Parameters.AddWithValue("@lecture", e.lecturer);
            cmd.Parameters.AddWithValue("@activityID", e.acti.ID);
            cmd.Parameters.AddWithValue("@locationID", e.location.ID);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message);
            }
        }

        public Event getEventByID(int ID)
        {
            string query = "SELECT ID, date, lecture, activityID, locationID from ScrumEvent WHERE ID=" + ID;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Event e = new Event();
            int activitiID;
            int locationID;
            while (dr.HasRows)
            {
                e.ID = dr.GetInt32(0);
                e.date = dr.GetDateTime(1);
                e.lecturer = dr.GetString(2);
                activitiID = dr.GetInt32(3);
                locationID = dr.GetInt32(4);
            }
            //Activity a = dba.getActivityByID(acivityID);
            //Location l = dbl.getLocationByID(locationID);
            //e.acti = a;
            //e.location = l;

            return e;
        }

    }
}