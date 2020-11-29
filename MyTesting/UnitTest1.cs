using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalAssignment.DataAccessLayer;
using MovieRentalAssignment.Utility;

namespace MyTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlConnection conn = DataBaseConnection.OpenConnection();
            bool status = conn != null;
            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int days = new CalculateDays().TotalDays("26-11-2020", "30-11-2020");
            int expectedvalue = 4;
            Assert.AreEqual(expectedvalue,days);
        }
    }
}
