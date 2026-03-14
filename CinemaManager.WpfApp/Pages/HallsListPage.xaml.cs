using System.Windows.Controls;
using CinemaManager.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using CinemaManager.Services;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallsListPage : Page // All halls
    {
        private readonly ICinemaService _cinemaService;

        public HallsListPage()
        {
            InitializeComponent();
            _cinemaService = App.ServiceProvider.GetRequiredService<ICinemaService>();
            // Load halls list from service
            HallsListBox.ItemsSource = _cinemaService.GetAllHalls();
        }

        private void HallsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) // Navigate to hall details on selection
        {
            if (HallsListBox.SelectedItem is CinemaHallViewModel selectedHall)
            {
                NavigationService?.Navigate(new HallDetailsPage(selectedHall.Id));
            }
        }
    }
}
