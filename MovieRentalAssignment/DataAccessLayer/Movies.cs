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
    public class Movies
    {
        // Insert Movie
        public bool InsertMovie(MoviesData data)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "InsertMovie";
            cmd.CommandType = CommandType.StoredProcedure; // store procedure
            cmd.Parameters.AddWithValue("@Title", data.Title);
            cmd.Parameters.AddWithValue("@Year", data.Year);
            cmd.Parameters.AddWithValue("@RentCost", data.RentCost);
            cmd.Parameters.AddWithValue("@Genre", data.Genre);
            cmd.Parameters.AddWithValue("@Rating", data.Rating);
            cmd.Parameters.AddWithValue("@StoryLine", data.StoryLine);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Delete Movie
        public bool DeleteMovie(string MovieId)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "delete movies where MovieId=@MovieId";
            cmd.Parameters.AddWithValue("@MovieId", MovieId);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Show All Movies
        public DataTable ShowAllMovies()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();

            cmd.CommandText = "select * from Movies";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Show Movies Information
        public MoviesData ShowMovieInfoById(int movieID)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();

            cmd.CommandText = "ShowMovieByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieID", movieID);
            MoviesData data = null;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                data = new MoviesData();
                data.Title = reader[2].ToString();
                data.Rating = reader[1].ToString();
                data.RentCost = int.Parse(reader[4].ToString());
                data.Year = reader[3].ToString();
                data.StoryLine = reader[5].ToString();
                data.Genre = reader[6].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            return data;
        }

        // Show Movies in DropDown
        public DataTable ShowMovies()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "select * from Movies";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }


        // Update Movie
        public bool UpdateMovie(MoviesData data)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "UpdateMovieInform";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieId", data.MovieId);
            cmd.Parameters.AddWithValue("@title", data.Title);
            cmd.Parameters.AddWithValue("@year", data.Year);
            cmd.Parameters.AddWithValue("@rating", data.RentCost);
            cmd.Parameters.AddWithValue("@genre", data.Genre);
            cmd.Parameters.AddWithValue("@rentcost", data.Rating);
            cmd.Parameters.AddWithValue("@StoryLine", data.StoryLine);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Calculate Movie Cost 
        public int CalculateMovieCost(int MovieID)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "select RentCost from movies where MovieID=@MovieID";

            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            int RentCost = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                RentCost = int.Parse(reader["RentCost"].ToString());
            }
            reader.Close();
            cmd.Dispose();
            return RentCost;
        }
    }
}
