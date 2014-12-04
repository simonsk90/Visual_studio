﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.DB;
using System.Data.SqlClient;
using MvcApplication1.Models;
using MvcApplication1.Controllers;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class DBConnectionTest
    {

        [TestMethod]
        public async Task TestGetActivityController()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage response = await client.GetAsync("api/activity/2");
                if (response.IsSuccessStatusCode)
                {
                    Activity a = await response.Content.ReadAsAsync<Activity>();
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                    Assert.AreEqual(a.description, "yolo Marck er en fag");
                }
            }
        }

        [TestMethod]
        public async Task TestAddActivityController()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");

                var a = new Activity() { ID = 1337, title = "testTitle", description = "testDescription", tags = "testTags" };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Activity", a);
            }
        }

        [TestMethod]
        public async Task TestLocationController()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51938/");

                var a = new Location() { ID = 322, name = "testName", address = "testAddress", zipcode = 9999, city = "testCity" };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Location", a);
            }
        }

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
            //Activity a = new Activity(1337, "title", "DESC", "hugorm");
            //dba.addActivity(a);
        }

        [TestMethod]
        public void testGetActivity()
        {
            DBActivity dba = new DBActivity();
            Activity a = dba.getActivityByID(2);
            Console.WriteLine(a.title);
            Assert.AreNotEqual(a, null);
            
        }

        [TestMethod]
        public void testGetLocation()
        {
            DBLocation dba = new DBLocation();
            Location a = dba.getLocationByID(2);
            Console.WriteLine(a.name);
            Assert.AreNotEqual(a, null);

        }

        [TestMethod]
        public void TestGetEvent()
        {
            //DBEvent dbe = new DBEvent();
            //dbe.addEvent(new Event(new DateTime(), new Location("Hey", "fagvej", 8900, "YoBy"), "Marcks mor", new Activity(89,"Neeeej", "Blaaa","fucker,popcorn,#OgMinMaaaajd")));
            //Event e = dbe.getEventByID(0);
            //Console.WriteLine(e.lecturer + " lecturer og " + e.date + " date");
        }

        //[TestMethod]
        //public async Task TestAddEventController()
        //{
        //    DBActivity dba = new DBActivity();
        //    DBLocation dbl = new DBLocation();
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:51938/");

        //        Location l = dbl.getLocationByID(1);
        //        Activity a = dba.getActivityByID(2);
        //        DateTime dt = new DateTime(1993, 2, 2, 4, 44, 7);
        //        var e = new Event() { date = dt, location = l, lecturer = "marcks mor", acti = a };
        //        HttpResponseMessage response = await client.PostAsJsonAsync("api/Event", e);
        //    }
        //}

        //[TestMethod]
        //public void TestAddEventDB()
        //{
        //    DBActivity dba = new DBActivity();
        //    DBLocation dbl = new DBLocation();
        //    DBEvent dbe = new DBEvent();
        //    Location l = dbl.getLocationByID(1);
        //    Activity a = dba.getActivityByID(2);
        //    DateTime dt = new DateTime(1993, 2, 2, 4, 44, 7);
        //    Event eN = new Event();
        //    eN.date = dt;
        //    eN.lecturer = "Marcks mor";
        //    eN.location = l;
        //    eN.acti = a;
        //    //Event e = new Event(dt, l, "Marcks mor", a);
        //    dbe.addEvent(eN);
        //}

        //[TestMethod]
        //public async Task TestGetEventController()
        //{

        //}
        
    }
}
