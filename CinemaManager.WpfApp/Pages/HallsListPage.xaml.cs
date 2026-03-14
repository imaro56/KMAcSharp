using System.Windows.Controls;
using CinemaManager.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using CinemaManager.Services;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallsListPage : Page
    {
        private readonly ICinemaService cinemaService_;
        public HallsListPage()
        {
            InitializeComponent();
            cinemaService_ = App.ServiceProvider.GetRequiredService<ICinemaService>();
            HallsListBox.ItemsSource = cinemaService_.GetAllHalls();
        }

        private void HallsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HallsListBox.SelectedItem is CinemaHallViewModel selectedHall)
            {
                NavigationService?.Navigate(new HallDetailsPage(selectedHall.Id));
            }
        }   
    }
}
