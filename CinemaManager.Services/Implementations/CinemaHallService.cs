using CinemaManager.Repositories.Interfaces;
using CinemaManager.Services.DTOs;
using CinemaManager.Services.Interfaces;

namespace CinemaManager.Services.Implementations
{
    public class CinemaHallService : ICinemaHallService
    {
        private readonly ICinemaHallRepository _hallRepository;
        private readonly IMovieSessionRepository _sessionRepository;

        
        public CinemaHallService(ICinemaHallRepository hallRepository, IMovieSessionRepository sessionRepository) // DI via constructor
        {
            _hallRepository = hallRepository;
            _sessionRepository = sessionRepository;
        }

        public IReadOnlyList<CinemaHallListDTO> GetAllForList()
        {
            return _hallRepository.GetAll()
                .Select(entity => new CinemaHallListDTO
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Type = entity.Type
                }).ToList();
        }

        public CinemaHallDetailsDTO? GetDetails(int id)
        {
            var hall = _hallRepository.GetById(id);
            if (hall == null) return null;

            var sessions = _sessionRepository.GetByHallId(id);

            return new CinemaHallDetailsDTO
            {
                Id = hall.Id,
                Name = hall.Name,
                SeatsNumber = hall.SeatsNumber,
                Type = hall.Type,
                SessionsCount = sessions.Count,
                TotalDurationMinutes = sessions.Sum(s => s.DurationMinutes),
                Sessions = sessions.Select(s => new MovieSessionListDTO
                {
                    Id = s.Id,
                    MovieName = s.MovieName,
                    StartTime = s.StartTime
                }).ToList()
            };
        }
    }
}