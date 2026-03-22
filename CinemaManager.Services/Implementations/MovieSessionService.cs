using CinemaManager.Repositories.Interfaces;
using CinemaManager.Services.DTOs;
using CinemaManager.Services.Interfaces;

namespace CinemaManager.Services.Implementations
{
    public class MovieSessionService : IMovieSessionService
    {
        private readonly IMovieSessionRepository _sessionRepository;
        private readonly ICinemaHallRepository _hallRepository;

        public MovieSessionService(
            IMovieSessionRepository sessionRepository,
            ICinemaHallRepository hallRepository)
        {
            _sessionRepository = sessionRepository;
            _hallRepository = hallRepository;
        }

        public IReadOnlyList<MovieSessionListDTO> GetByHallId(int hallId)
        {
            return _sessionRepository.GetByHallId(hallId)
                .Select(s => new MovieSessionListDTO
                {
                    Id = s.Id,
                    MovieName = s.MovieName,
                    StartTime = s.StartTime
                }).ToList();
        }

        public MovieSessionDetailsDTO? GetDetails(int id)
        {
            var session = _sessionRepository.GetById(id);
            if (session == null) return null;

            var hall = _hallRepository.GetById(session.CinemaHallId);

            return new MovieSessionDetailsDTO
            {
                Id = session.Id,
                CinemaHallId = session.CinemaHallId,
                MovieName = session.MovieName,
                Genre = session.Genre,
                ReleaseYear = session.ReleaseYear,
                StartTime = session.StartTime,
                DurationMinutes = session.DurationMinutes,
                EndTime = session.StartTime.AddMinutes(session.DurationMinutes),
                CinemaHallName = hall?.Name ?? "-"
            };
        }
    }
}