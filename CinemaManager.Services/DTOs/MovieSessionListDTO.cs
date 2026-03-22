using CinemaManager.Repositories.Models;

namespace CinemaManager.Services.DTOs
{
    public class MovieSessionListDTO
    {
        public int Id { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
    }
}
