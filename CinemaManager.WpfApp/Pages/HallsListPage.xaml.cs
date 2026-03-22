using System.Windows.Controls;
using CinemaManager.WpfApp.ViewModels;

namespace CinemaManager.WpfApp.Pages
{
    public partial class HallsListPage : Page
    {
        public HallsListPage(HallListViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}