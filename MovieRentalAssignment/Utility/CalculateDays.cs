using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.Utility
{
    public class CalculateDays
    {
        //Most popular movies
        public int TotalDays(string issueDate, string returnDate)
        {
            int totalDays = 0;
            totalDays = Convert.ToInt32((DateTime.Parse(returnDate) - DateTime.Parse(issueDate)).TotalDays);
            return totalDays;
        }
    }
}
