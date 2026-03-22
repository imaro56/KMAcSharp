using CinemaManager.Services.DTOs;

namespace CinemaManager.Services.Interfaces
{
    public interface ICinemaHallService // interface for cinema hall operations
    {
        IReadOnlyList<CinemaHallListDTO> GetAllForList();
        CinemaHallDetailsDTO? GetDetails(int id);
    }
}