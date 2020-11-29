using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.PresentationLayer
{
    public class RentedMoviesData
    {
        // Rented movie data
        public int RentId { get; set; }
        public int MovieId { get; set; }
        public int CustId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
        public int TotalRentAmount { get; set; }
    }
}
