using CinemaManager.Models;
namespace CinemaManager.ViewModels
{
    public class MovieSessionViewModel
    {
        public int Id { get; set; }
        public int CinemaHallId { get; set; }
        public string MovieName { get; set; }
        public MovieGenre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; }

        // No need to store End time, because we can calculate it
        public DateTime EndTime => StartTime.AddMinutes(DurationMinutes);
    }
}
