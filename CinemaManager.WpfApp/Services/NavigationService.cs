using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;


namespace CinemaManager.WpfApp.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;
        private Frame? _frame;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void SetFrame(Frame frame)
        {
            _frame = frame;
        }

        public void NavigateTo<TPage>(object? parameter = null) where TPage : Page
        {
            var page = _serviceProvider.GetRequiredService<TPage>();

            if (parameter != null && page.DataContext is INavigationAware navAware)
            {
                navAware.OnNavigatedTo(parameter);
            }

            _frame?.Navigate(page);
        }

        public void GoBack()
        {
            if (_frame?.CanGoBack == true)
                _frame.GoBack();
        }
    }

    public interface INavigationAware
    {
        void OnNavigatedTo(object parameter);
    }
}
