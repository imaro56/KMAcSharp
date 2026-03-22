using CinemaManager.Repositories.Models;

namespace CinemaManager.Repositories.Interfaces
{
    public interface ICinemaHallRepository
    {
        IReadOnlyList<CinemaHallEntity> GetAll();
        CinemaHallEntity? GetById(int id);
    }
}