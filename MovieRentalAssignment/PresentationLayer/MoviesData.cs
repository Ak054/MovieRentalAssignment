using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.PresentationLayer
{
    public class MoviesData
    {
        // Movies Data
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public string StoryLine { get; set; }
        public int RentCost { get; set; }
        
    }
}
