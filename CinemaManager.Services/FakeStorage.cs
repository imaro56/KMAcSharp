using CinemaManager.Models;
namespace CinemaManager.Services
{
    internal static class FakeDataStore
    {
        public static List<CinemaHallEntity> CinemaHalls { get; } = new List<CinemaHallEntity> //Fake storage for cinema halls
        {
            new CinemaHallEntity(1, "Green", 120, CinemaHallType.TwoD),
            new CinemaHallEntity(2, "Blue", 80, CinemaHallType.ThreeD),
            new CinemaHallEntity(3, "Red", 200, CinemaHallType.IMAX)
        };

        public static List<MovieSessionEntity> MovieSessions { get; } = new List<MovieSessionEntity> //Fake storage for movie sessions
        {
            // Hall 1 sessions (10 sessions)
            new MovieSessionEntity(1, 1, "Peaky Blinders: The Movie", MovieGenre.Action, 2024, new DateTime(2025, 6, 1, 9, 0, 0), 135),
            new MovieSessionEntity(2, 1, "Avatar", MovieGenre.Action, 2009, new DateTime(2025, 6, 1, 11, 30, 0), 162),
            new MovieSessionEntity(3, 1, "The Lion King", MovieGenre.Animation, 2019, new DateTime(2025, 6, 1, 14, 30, 0), 118),
            new MovieSessionEntity(13, 1, "Harry Potter and the Philosopher's Stone", MovieGenre.Fantasy, 2001, new DateTime(2025, 6, 3, 10, 0, 0), 152),
            new MovieSessionEntity(5, 1, "Interstellar", MovieGenre.Action, 2014, new DateTime(2025, 6, 1, 20, 0, 0), 169),
            new MovieSessionEntity(6, 1, "Spider-Man: No Way Home", MovieGenre.Action, 2021, new DateTime(2025, 6, 2, 10, 0, 0), 148),
            new MovieSessionEntity(7, 1, "Shrek", MovieGenre.Animation, 2001, new DateTime(2025, 6, 2, 13, 0, 0), 90),
            new MovieSessionEntity(8, 1, "The Dark Knight", MovieGenre.Action, 2008, new DateTime(2025, 6, 2, 15, 0, 0), 152),
            new MovieSessionEntity(9, 1, "Oppenheimer", MovieGenre.Drama, 2023, new DateTime(2025, 6, 2, 18, 0, 0), 180),
            new MovieSessionEntity(10, 1, "Dune: Part Two", MovieGenre.Action, 2024, new DateTime(2025, 6, 2, 21, 30, 0), 166),

            // Hall 2 sessions (2 sessions)
            new MovieSessionEntity(11, 2, "Avatar: The Way of Water", MovieGenre.Action, 2022, new DateTime(2025, 6, 1, 18, 0, 0), 192),
            new MovieSessionEntity(12, 2, "Wednesday", MovieGenre.Comedy, 2024, new DateTime(2025, 6, 1, 21, 30, 0), 110)
        };
    }
}
