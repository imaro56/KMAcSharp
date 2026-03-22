using CinemaManager.Repositories.Models;

namespace CinemaManager.Repositories.Interfaces
{
    public interface IMovieSessionRepository
    {
        IReadOnlyList<MovieSessionEntity> GetAll();
        IReadOnlyList<MovieSessionEntity> GetByHallId(int hallId);
        MovieSessionEntity? GetById(int id);
    }
}
