using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;
using CinemaManager.Services;
using CinemaManager.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallDetailsPage : Page // Hall details page
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

            // Get sessions
            var sessions = _cinemaService.GetSessionsForHall(_hallId);

            // hall info
            HallNameText.Text = hall.Name;
            HallIdText.Text = $"ID: {hall.Id}";
            HallTypeText.Text = $"Type: {hall.Type}";
            HallSeatsText.Text = $"Seats: {hall.SeatsNumber}";

            int totalDuration = sessions.Sum(s => s.DurationMinutes);
            TotalDurationText.Text = $"Total sessions duration: {totalDuration} min";

            // Displaing sessions
            SessionsListBox.ItemsSource = sessions;
        }

        private void SessionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) // Navigate to session details on selection
        {
            if (SessionsListBox.SelectedItem is MovieSessionViewModel selectedSession)
            {
                NavigationService?.Navigate(new SessionDetailsPage(selectedSession));
            }
        }
    }
}
