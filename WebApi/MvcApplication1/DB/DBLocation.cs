using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.DB
{
    public class DBLocation
    {
        DBConnection dbc = new DBConnection();

        public void addLocation(Location l)
        {
            string query = "INSERT INTO ScrumLocation (name, address, zipcode, city) VALUES (@name, @address, @zipcode, @city)";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", l.name);
            cmd.Parameters.AddWithValue("@address", l.address);
            cmd.Parameters.AddWithValue("@zipcode", l.zipcode);
            cmd.Parameters.AddWithValue("@city", l.city);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Location getLocationByID(int lID)
        {
            Location l = new Location();
            string query = "SELECT * FROM ScrumLocation WHERE ID = " + lID;
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                l = new Location(Convert.ToInt32(dr["ID"]), dr["name"].ToString(),
                dr["address"].ToString(), Convert.ToInt32(dr["zipcode"]), dr["city"].ToString());
            }
            return l;
        }

        public List<Location> getAllLocations()
        {
            List<Location> allLocations = new List<Location>();
            string query = "SELECT * FROM ScrumLocation";
            SqlConnection con = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.HasRows)
            {
                l = new Location(Convert.ToInt32(dr["ID"]), dr["name"].ToString(),
                dr["address"].ToString(), Convert.ToInt32(dr["zipcode"]), dr["city"].ToString());
                allLocations.Add(l);
            }
            return allLocations;
        }
    }
}