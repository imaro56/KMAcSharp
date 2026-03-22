using System.Windows.Controls;

namespace CinemaManager.WpfApp.Services
{
    public interface INavigationService
    {
        void NavigateTo<TPage>(object? parameter = null) where TPage : Page;
        void GoBack();
    }
}
