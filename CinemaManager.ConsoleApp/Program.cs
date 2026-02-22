using CinemaManager.Services;
using CinemaManager.ViewModels;

namespace CinemaManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new CinemaService(); // Service for getting data from fake storage
            bool isRunning = true;

            while (isRunning) // Running until we recieve signal to exit
            {
                Console.Clear();
                var halls = service.GetAllHalls();

                for (int i = 0; i < halls.Count; i++) // Ids can be random, so we generate numbers in a row
                {
                    Console.WriteLine($"{i + 1}. {halls[i].Name} ({halls[i].Type}, {halls[i].SeatsNumber} seats)");
                }

                Console.WriteLine("\n0. Exit");
                Console.Write("\nSelect a cinema hall by its number: ");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    isRunning = false;
                    continue;
                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= halls.Count) // Parser for number and if we get it right
                {
                    var selectedHall = halls[choice - 1];

                    selectedHall.MovieSessions = service.GetSessionsForHall(selectedHall.Id);

                    Console.Clear();
                    Console.WriteLine($"{selectedHall.Name}");
                    Console.WriteLine($"Type: {selectedHall.Type}");
                    Console.WriteLine($"Number of seats: {selectedHall.SeatsNumber}");
                    Console.WriteLine($"Total session duration: {selectedHall.TotalDurationMinutes} minutes\n");

                    if (selectedHall.MovieSessions.Count == 0)
                    {
                        Console.WriteLine("No sessions available.");
                    }
                    else
                    {
                        Console.WriteLine("Sessions:");
                        for (int i = 0; i < selectedHall.MovieSessions.Count; i++) //Same as with halls, we generate numbers in a row
                        {
                            var session = selectedHall.MovieSessions[i];
                            Console.WriteLine($"  {i + 1}. {session.MovieName} ({session.Genre}, {session.ReleaseYear})");
                            Console.WriteLine($"     Start: {session.StartTime:dd.MM.yyyy HH:mm} | Duration: {session.DurationMinutes} min | End: {session.EndTime:dd.MM.yyyy HH:mm}");
                        }
                    }

                    Console.WriteLine("\n0. Go back");
                    Console.WriteLine("\nSelect a session by number to look its details ");

                    string inputSession = Console.ReadLine();
                    if (inputSession == "0") {
                        continue;
                    }
                    if (int.TryParse(inputSession, out int choiceSession) && choiceSession >= 1 && choiceSession <= selectedHall.MovieSessions.Count) // Same parser as we have for halls
                    {
                        // Details for each session
                        var s = selectedHall.MovieSessions[choiceSession - 1];
                        Console.Clear();
                        Console.WriteLine($"Session Details");
                        Console.WriteLine($"ID: {s.Id}");
                        Console.WriteLine($"Movie: {s.MovieName}");
                        Console.WriteLine($"Genre: {s.Genre}");
                        Console.WriteLine($"Release Year: {s.ReleaseYear}");
                        Console.WriteLine($"Start: {s.StartTime:dd.MM.yyyy HH:mm}");
                        Console.WriteLine($"Duration: {s.DurationMinutes} min");
                        Console.WriteLine($"End: {s.EndTime:dd.MM.yyyy HH:mm}");

                        Console.WriteLine("\nPress any key to go back...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}