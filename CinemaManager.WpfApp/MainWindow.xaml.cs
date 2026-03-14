using CinemaManager.WpfApp.Pages;
using System.Windows;

namespace CinemaManager.WpfApp
{
    public partial class MainWindow : Window // show main window
    {
        public MainWindow()
        {
            InitializeComponent();
            // open halls list page on startup
            MainFrame.Navigate(new HallsListPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) // back navigation
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
