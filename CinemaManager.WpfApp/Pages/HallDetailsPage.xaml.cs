using System.Windows.Controls;
using CinemaManager.WpfApp.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallDetailsPage : Page
    {
        public HallDetailsPage(HallDetailsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}