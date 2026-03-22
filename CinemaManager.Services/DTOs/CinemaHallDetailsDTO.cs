using CinemaManager.Repositories.Models;

namespace CinemaManager.Services.DTOs
{
    public class CinemaHallDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CinemaHallType Type { get; set; }
        public int SeatsNumber { get; set; }
        public int SessionsCount { get; set; }
        public int TotalDurationMinutes { get; set; }
        public List<MovieSessionListDTO> Sessions { get; set; } = new();
    }
}
