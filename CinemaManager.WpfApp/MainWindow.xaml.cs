using CinemaManager.WpfApp.Pages;
using CinemaManager.WpfApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace CinemaManager.WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // configure NavigationService
            var navigationService = App.ServiceProvider.GetRequiredService<NavigationService>();
            navigationService.SetFrame(MainFrame);

            // open hall list page on start
            navigationService.NavigateTo<HallsListPage>();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}