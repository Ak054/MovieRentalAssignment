using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.DataAccessLayer
{
    public class DataBaseConnection
    {
        private static SqlConnection sqlCon = null;

        private DataBaseConnection() { }

        //Open Database Connection 
        public static SqlConnection OpenConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection
                {
                    ConnectionString = @"Data Source=LAPTOP-88F3P2E9;integrated security=true;initial catalog=MovieRentalSys"
                };
                sqlCon.Open();
            }

            return sqlCon;
        }

        //Close Connection
        public static void CloseConnection()
        {
            if (sqlCon != null)
            {
                sqlCon.Dispose();
            }
            sqlCon = null;
        }

    }
}
