using CinemaManager.ViewModels;

namespace CinemaManager.Services
{
    public class CinemaService
    {
        public List<CinemaHallViewModel> GetAllHalls() // Get list for all halls in fake storage
        {
            return FakeDataStore.CinemaHalls
                .Select(hall => new CinemaHallViewModel
                {
                    Id = hall.Id,
                    Name = hall.Name,
                    SeatsNumber = hall.SeatsNumber,
                    Type = hall.Type
                }).ToList();
        }

        public List<MovieSessionViewModel> GetSessionsForHall(int hallId) // Get list of sessions for certain hall in fake storage
        {
            return FakeDataStore.MovieSessions
                .Where(session => session.CinemaHallId == hallId)
                .Select(session => new MovieSessionViewModel
                {
                    Id = session.Id,
                    CinemaHallId = session.CinemaHallId,
                    MovieName = session.MovieName,
                    Genre = session.Genre,
                    ReleaseYear = session.ReleaseYear,
                    StartTime = session.StartTime,
                    DurationMinutes = session.DurationMinutes
                }).ToList();
        }
    }
}
