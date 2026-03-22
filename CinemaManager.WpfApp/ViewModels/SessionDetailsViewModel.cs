using CinemaManager.Services.DTOs;
using CinemaManager.Services.Interfaces;
using CinemaManager.WpfApp.Commands;
using CinemaManager.WpfApp.Services;
using System.Windows.Input;
using CinemaManager.WpfApp.Pages;

namespace CinemaManager.WpfApp.ViewModels
{
    public class SessionDetailsViewModel : ViewModelBase, INavigationAware

    {
        private readonly IMovieSessionService _sessionService;
        private readonly INavigationService _navigationService;

        private MovieSessionDetailsDTO? _session;
        public MovieSessionDetailsDTO? Session
        {
            get => _session;
            set => SetProperty(ref _session, value);
        }

        public ICommand GoBackCommand { get; }

        public SessionDetailsViewModel(IMovieSessionService sessionService, INavigationService navigationService)
        {
            _sessionService = sessionService;
            _navigationService = navigationService;

            GoBackCommand = new RelayCommand(() => _navigationService.GoBack());
        }

        public void OnNavigatedTo(object parameter)
        {
            if (parameter is int sessionId)
            {
                Session = _sessionService.GetDetails(sessionId);
            }
        }
    }
}
