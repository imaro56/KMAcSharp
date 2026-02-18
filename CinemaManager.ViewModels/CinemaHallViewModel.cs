using CinemaManager.Models;
namespace CinemaManager.ViewModels
{
    public class CinemaHallViewModel
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public CinemaHallType Type { get; set; }

        // Create empty list to prevent null exceptions when adding sessions to the hall
        public List<MovieSessionViewModel> MovieSessions { get; set; } = new List<MovieSessionViewModel>();

        // No need to store it in Model, we can calculate it
        public int TotalDurationMinutes => MovieSessions.Sum(ms => ms.DurationMinutes);
    }
}
