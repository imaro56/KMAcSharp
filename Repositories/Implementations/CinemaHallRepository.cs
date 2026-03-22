using CinemaManager.Repositories.Interfaces;
using CinemaManager.Repositories.Models;
using CinemaManager.Repositories.Storage;

namespace CinemaManager.Repositories.Implementations
{
    public class CinemaHallRepository : ICinemaHallRepository
    {
        public IReadOnlyList<CinemaHallEntity> GetAll()
        {
            return FakeDataStore.CinemaHalls;
        }

        public CinemaHallEntity? GetById(int id)
        {
            return FakeDataStore.CinemaHalls.FirstOrDefault(hall => hall.Id == id);
        }
    }
}