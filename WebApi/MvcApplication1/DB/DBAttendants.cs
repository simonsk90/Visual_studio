using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.DB
{
    public class DBAttendants
    {
        DBConnection dbc = new DBConnection();
        DBUser dbu = new DBUser();
        DBEvent dbe = new DBEvent();

        public void addAttendants(Attendants a)
        {
            string query = "INSERT INTO ScrumAttendants (eventID, userID) VALUES (@eventID, @userID)";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@eventID", a.eventID);
            cmd.Parameters.AddWithValue("@userID", a.userID);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<User> getAttendantsByEvent(int eventID)
        {
            List<User> allUsers = new List<User>();
            string query = "SELECT eventID, userID FROM ScrumAttendants WHERE eventID = " + eventID ;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["userID"] != null)
                    {
                        User u = dbu.getUserByID(Convert.ToInt32(dr["userID"]));
                        allUsers.Add(u);
                    }
                }
            }
            return allUsers;
        }

        public List<Event> getEventsByUser(int userID)
        {
            List<Event> allEvents = new List<Event>();
            string query = "SELECT eventID, userID FROM ScrumAttendants WHERE userID = " + userID;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Event e = dbe.getEventByID(Convert.ToInt32(dr["eventID"]));
                    allEvents.Add(e);
                }
            }
            return allEvents;
        }

    }
}