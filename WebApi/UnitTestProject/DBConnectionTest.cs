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
            DBActivity dba = new DBActivity();
            Activity a = new Activity("title", "DESC");
            dba.addActivity(a);
        }
    }
}
