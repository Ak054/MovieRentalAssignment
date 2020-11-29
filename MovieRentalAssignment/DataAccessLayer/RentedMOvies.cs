using MovieRentalAssignment.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.DataAccessLayer
{
    public class RentedMOvies
    {
        //Show All Rented Movies
        public DataTable ShowAllRentedMovies()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
           
            cmd.CommandText = "ShowAllRentedMovies";
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            
            return ds;
        }

        //Most popular movies
        public DataTable MostPopularMovies()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "ShowMostPopularMovies"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            cmd.Dispose();
            return dtable;
        }


        //Customers borrows most movies
        public DataTable CustBorrowMostMovies()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "CustBorrowMostMovies"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }


        // Insert Movie
        public bool InsertRentedMovie(RentedMoviesData data)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "RentThisMovie";
            cmd.CommandType = CommandType.StoredProcedure; // store procedure
            cmd.Parameters.AddWithValue("@MovieID", data.MovieId);
            cmd.Parameters.AddWithValue("@CustID", data.CustId);
            cmd.Parameters.AddWithValue("@RentDate", data.RentDate);
            cmd.Parameters.AddWithValue("@ReturnDate", data.ReturnDate);
            cmd.Parameters.AddWithValue("@TotalRent", data.TotalRentAmount);
           
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        // Show RentedMovies By customerID
        public DataTable ShowRentedMoviesDDL(int custId)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "ShowRentedMovieByCustomerID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custID", custId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }


        // Return Movie
        public bool ReturnThisMovie(int MovieID, int CustId)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = " delete from RentedMovies where MovieID=@MovieID and CustID= @CustID"; 
            
            cmd.Parameters.AddWithValue("@movieID", MovieID);
            cmd.Parameters.AddWithValue("@CustID", CustId);

            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }
    }
}
