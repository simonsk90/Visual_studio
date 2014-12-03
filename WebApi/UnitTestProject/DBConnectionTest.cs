using System;
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
        public void TestGetEvent()
        {
            //DBEvent dbe = new DBEvent();
            //dbe.addEvent(new Event(new DateTime(), new Location("Hey", "fagvej", 8900, "YoBy"), "Marcks mor", new Activity(89,"Neeeej", "Blaaa","fucker,popcorn,#OgMinMaaaajd")));
            //Event e = dbe.getEventByID(0);
            //Console.WriteLine(e.lecturer + " lecturer og " + e.date + " date");
        }

        
    }
}
