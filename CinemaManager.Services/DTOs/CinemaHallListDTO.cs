using CinemaManager.Repositories.Models;

namespace CinemaManager.Services.DTOs
{
    public class CinemaHallListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CinemaHallType Type { get; set; }
    }
}
