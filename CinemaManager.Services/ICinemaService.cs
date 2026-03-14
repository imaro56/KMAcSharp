using CinemaManager.ViewModels;

namespace CinemaManager.Services
{
    public interface ICinemaService
    {
        IReadOnlyList<CinemaHallViewModel> GetAllHalls();
        IReadOnlyList<MovieSessionViewModel> GetSessionsForHall(int hallId);
    }
}
