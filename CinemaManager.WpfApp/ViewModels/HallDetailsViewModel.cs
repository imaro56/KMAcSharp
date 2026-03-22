using CinemaManager.Services.DTOs;
using CinemaManager.Services.Interfaces;
using CinemaManager.WpfApp.Commands;
using CinemaManager.WpfApp.Services;
using System.Windows.Input;
using CinemaManager.WpfApp.Pages;

namespace CinemaManager.WpfApp.ViewModels
{
    public class HallDetailsViewModel : ViewModelBase, INavigationAware
    {
        private readonly ICinemaHallService _hallService;
        private readonly INavigationService _navigationService;

        private CinemaHallDetailsDTO? _hall;
        public CinemaHallDetailsDTO? Hall
        {
            get => _hall;
            set => SetProperty(ref _hall, value);
        }

        private MovieSessionListDTO? _selectedSession;
        public MovieSessionListDTO? SelectedSession
        {
            get => _selectedSession;
            set => SetProperty(ref _selectedSession, value);
        }
        
        public ICommand OpenSessionCommand { get; }
        public ICommand GoBackCommand { get; }

        public HallDetailsViewModel(ICinemaHallService hallService, INavigationService navigationService)
        {
            _hallService = hallService;
            _navigationService = navigationService;

            OpenSessionCommand = new RelayCommand(OpenSession, () => SelectedSession != null);
            GoBackCommand = new RelayCommand(() => _navigationService.GoBack());
        }

        public void OnNavigatedTo(object parameter)
        {
            if (parameter is int hallId)
            {
                Hall = _hallService.GetDetails(hallId);
            }
        }

        private void OpenSession()
        {
            if (SelectedSession != null)
            {
                _navigationService.NavigateTo<SessionDetailsPage>(SelectedSession.Id);
            }
        }
    }
}
