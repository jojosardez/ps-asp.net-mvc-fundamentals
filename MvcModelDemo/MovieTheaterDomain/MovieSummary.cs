using System;

namespace MovieTheaterDomain
{
    public class MovieSummary
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double? AverageRating { get; set; }
    }
}
