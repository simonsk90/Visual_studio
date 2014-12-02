using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.DB;
using System.Data.SqlClient;
using MvcApplication1.Models;

namespace UnitTestProject
{
    [TestClass]
    public class DBConnectionTest
    {
        [TestMethod]
        public void TestDBCon()
        {
            var dbcon = new DBConnection();
            dbcon.GetConnection();
        }

        [TestMethod]
        public void TestAddActivity()
        {
            //DBActivity dba = new DBActivity();
            //Activity a = new Activity("title", "DESC");
            //dba.addActivity(a);
        }

        [TestMethod]
        public void testGetActivity()
        {
            DBActivity dba = new DBActivity();
            Activity a = dba.getActivityByID(2);
            Console.WriteLine(a.title);
        }


        public void TestGetEvent()
        {
            DBEvent dbe = new DBEvent();
            dbe.addEvent(new Event(new DateTime(), new Location("Hey", "fagvej", 8900, "YoBy"), "Marcks mor", new Activity(89,"Neeeej", "Blaaa","fucker,popcorn,#OgMinMaaaajd")));
            Event e = dbe.getEventByID(0);
            Console.WriteLine(e.lecturer + " lecturer og " + e.date + " date");
        }
    }
}
