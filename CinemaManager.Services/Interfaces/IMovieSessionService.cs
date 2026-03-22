using CinemaManager.Services.DTOs;

namespace CinemaManager.Services.Interfaces
{
    public interface IMovieSessionService
    {
        IReadOnlyList<MovieSessionListDTO> GetByHallId(int hallId);
        MovieSessionDetailsDTO? GetDetails(int id);
    }
}