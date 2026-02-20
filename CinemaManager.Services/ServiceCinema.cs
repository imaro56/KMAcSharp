using CinemaManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Services
{
    public class CinemaService
    {
        public List<CinemaHallViewModel> GetAllHalls()
        {
            return FakeDataStore.CinemaHalls.Select(hall => new CinemaHallViewModel
            {
                Id = hall.Id,
                Name = hall.Name,
                SeatsNumber = hall.SeatsNumber,
                Type = hall.Type
            }).ToList();
        }

        public List<MovieSessionViewModel> GetSessionsByHall(int hallId)
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
