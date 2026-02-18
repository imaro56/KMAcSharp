using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    public class MovieSessionEntity
    {
        public int Id { get; }
        public int CinemaHallId { get; }
        public string MovieName { get; set; }
        public MovieGenre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; }
        public MovieSessionEntity(int id, int cinemaHallId, string movieName, MovieGenre genre, int releaseYear, DateTime startTime, int durationMinutes)
        {
            Id = id;
            CinemaHallId = cinemaHallId;
            MovieName = movieName;
            Genre = genre;
            ReleaseYear = releaseYear;
            StartTime = startTime;
            DurationMinutes = durationMinutes;
        }
    }
}