using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.DB;
using System.Data.SqlClient;

namespace UnitTestProject
{
    [TestClass]
    public class DBConnectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DBConnection dbcon = new DBConnection();
            dbcon.GetConnection();

        }
    }
}
