using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;
using CinemaManager.Services;
using CinemaManager.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallDetailsPage : Page
    {
        private readonly ICinemaService _cinemaService;
        private readonly int _hallId;

        public HallDetailsPage(int hallId)
        {
            InitializeComponent();

            _hallId = hallId;
            _cinemaService = App.ServiceProvider.GetRequiredService<ICinemaService>();

            LoadHallDetails();
        }

        private void LoadHallDetails()
        {
            // Get hall info
            var halls = _cinemaService.GetAllHalls();
            var hall = halls.FirstOrDefault(h => h.Id == _hallId);

            if (hall == null) return;

            // Get sessions for this hall
            var sessions = _cinemaService.GetSessionsForHall(_hallId);

            // Display hall info
            HallNameText.Text = hall.Name;
            HallTypeText.Text = $"Type: {hall.Type}";
            HallSeatsText.Text = $"Seats: {hall.SeatsNumber}";

            // Calculate total duration
            int totalDuration = sessions.Sum(s => s.DurationMinutes);
            TotalDurationText.Text = $"Total sessions duration: {totalDuration} min";

            // Display sessions
            SessionsListBox.ItemsSource = sessions;
        }

        private void SessionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SessionsListBox.SelectedItem is MovieSessionViewModel selectedSession)
            {
                NavigationService?.Navigate(new SessionDetailsPage(selectedSession));
            }
        }
    }
}
