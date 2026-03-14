using CinemaManager.Models;
namespace CinemaManager.ViewModels
{
    public class CinemaHallViewModel // View model for halls, that contains all info that should be displayed
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public CinemaHallType Type { get; set; }

        // Create empty list to prevent null exceptions when adding sessions to the hall
        public IReadOnlyList<MovieSessionViewModel> MovieSessions { get; init; } = Array.Empty<MovieSessionViewModel>();

        // No need to store it in Model, we can calculate it
        public int TotalDurationMinutes => MovieSessions.Sum(ms => ms.DurationMinutes);
    }
}
