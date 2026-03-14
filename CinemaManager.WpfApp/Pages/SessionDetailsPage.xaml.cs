using System.Windows.Controls;
using CinemaManager.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class SessionDetailsPage : Page
    {
        public SessionDetailsPage(MovieSessionViewModel session)
        {
            InitializeComponent();

            // display all session details
            MovieNameText.Text = session.MovieName;
            GenreText.Text = $"Genre: {session.Genre}";
            YearText.Text = $"Release Year: {session.ReleaseYear}";
            StartTimeText.Text = $"Start Time: {session.StartTime:dd.MM.yyyy HH:mm}";
            DurationText.Text = $"Duration: {session.DurationMinutes} min";
            EndTimeText.Text = $"End Time: {session.EndTime:dd.MM.yyyy HH:mm}";
            SessionIdText.Text = $"Session ID: {session.Id}";
            HallIdText.Text = $"Hall ID: {session.CinemaHallId}";
        }
    }
}
