using CinemaManager.Services.DTOs;

namespace CinemaManager.Services.Interfaces
{
    public interface ICinemaHallService
    {
        IReadOnlyList<CinemaHallListDTO> GetAllForList();
        CinemaHallDetailsDTO? GetDetails(int id);
    }
}