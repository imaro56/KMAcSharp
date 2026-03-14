using CinemaManager.WpfApp.Pages;
using System.Windows;

namespace CinemaManager.WpfApp
{
    public partial class MainWindow : Window // show main window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Navigate to halls list page on startup
            MainFrame.Navigate(new HallsListPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) // Handle back navigation
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
            else
            {
                MainFrame.
            }
        }
    }
}
