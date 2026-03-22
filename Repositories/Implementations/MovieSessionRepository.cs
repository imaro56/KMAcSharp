using CinemaManager.Repositories.Interfaces;
using CinemaManager.Repositories.Models;
using CinemaManager.Repositories.Storage;

namespace CinemaManager.Repositories.Implementations
{
    public class MovieSessionRepository : IMovieSessionRepository
    {
        public IReadOnlyList<MovieSessionEntity> GetAll()
        {
            return FakeDataStore.MovieSessions;
        }

        public IReadOnlyList<MovieSessionEntity> GetByHallId(int hallId)
        {
            return FakeDataStore.MovieSessions.Where(session => session.CinemaHallId == hallId).ToList();
        }

        public MovieSessionEntity? GetById(int id)
        {
            return FakeDataStore.MovieSessions.FirstOrDefault(session => session.Id == id);
        }

    }
}
