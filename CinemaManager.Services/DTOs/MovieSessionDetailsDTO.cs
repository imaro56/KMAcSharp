using CinemaManager.Repositories.Models;

namespace CinemaManager.Services.DTOs
{
    public class MovieSessionDetailsDTO
    {
        public int Id { get; set; }
        public int CinemaHallId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public MovieGenre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; }

        public DateTime EndTime { get; set; }
        public string CinemaHallName { get; set; } = string.Empty;
    }
}
