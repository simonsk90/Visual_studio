﻿using MvcApplication1.Models;
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
        DBActivity dba = new DBActivity();
        DBLocation dbl = new DBLocation();

        public void addEvent(Event e)
        {
            string query = "INSERT INTO ScrumEvent (eventDate, lecture, activityID, locationID) VALUES (@eventDate, @lecture, @activityID, @locationID)";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            String date = e.date.ToString();
            int aID = e.acti.ID;
            int lID = e.location.ID;
            cmd.Parameters.AddWithValue("@eventDate", date);
            cmd.Parameters.AddWithValue("@lecture", e.lecturer);
            cmd.Parameters.AddWithValue("@activityID", aID);
            cmd.Parameters.AddWithValue("@locationID", lID);

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
            string query = "SELECT ID, eventDate, lecture, activityID, locationID from ScrumEvent WHERE ID=" + ID;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Event e = new Event();
            int acivityID = 0;
            int locationID = 0;

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    e.ID = Convert.ToInt32(dr["id"]);
                    e.date = DateTime.ParseExact(dr["eventDate"].ToString(), "dd/MM/yyyy HH-mm", null);
                    e.lecturer = dr["lecture"].ToString();
                    acivityID = Convert.ToInt32(dr["activityID"]);
                    locationID = Convert.ToInt32(dr["locationID"]);
                }
            }
            Activity a = dba.getActivityByID(acivityID);
            Location l = dbl.getLocationByID(locationID);
            e.acti = a;
            e.location = l;

            return e;
        }

        public List<Event> getAllEvents()
        {
            List<Event> eList = new List<Event>();
            string query = "SELECT ID, eventDate, lecture, activityID, locationID FROM ScrumEvent";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Event e = new Event();
                    int acivityID = 0;
                    int locationID = 0;

                    e.ID = Convert.ToInt32(dr["ID"]);
                    String date = dr["eventDate"].ToString();
                    //e.date = DateTime.ParseExact(date, "dd/MM/yyyy HH-mm", null);
                    e.date = new DateTime(DateTime.MaxValue.Ticks);
                    e.lecturer = dr["lecture"].ToString();
                    acivityID = Convert.ToInt32(dr["activityID"]);
                    locationID = Convert.ToInt32(dr["locationID"]);
                    e.acti = dba.getActivityByID(acivityID);
                    e.location = dbl.getLocationByID(locationID);
                    eList.Add(e);
                }
            }

            return eList;
        }
    }
}