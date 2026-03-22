
using System.Windows.Controls;
using CinemaManager.WpfApp.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class SessionDetailsPage : Page
    {
        public SessionDetailsPage(SessionDetailsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}