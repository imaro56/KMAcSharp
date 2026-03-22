using CinemaManager.Services.DTOs;
using CinemaManager.Services.Interfaces;
using CinemaManager.WpfApp.Commands;
using CinemaManager.WpfApp.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CinemaManager.WpfApp.Pages;

namespace CinemaManager.WpfApp.ViewModels
{
    public class HallListViewModel : ViewModelBase
    {
        private readonly ICinemaHallService _hallService;
        private readonly INavigationService _navigationService;

        public ObservableCollection<CinemaHallListDTO> Halls { get; }

        private CinemaHallListDTO? _selectedHall;
        public CinemaHallListDTO? SelectedHall
        {
            get => _selectedHall;
            set => SetProperty(ref _selectedHall, value);
        }

        public ICommand OpenDetailsCommand { get; }

        public HallListViewModel(ICinemaHallService hallService, INavigationService navigationService)
        {
            _hallService = hallService;
            _navigationService = navigationService;

            Halls = new ObservableCollection<CinemaHallListDTO>(_hallService.GetAllForList());
            OpenDetailsCommand = new RelayCommand(OpenDetails, () => SelectedHall != null);

        }

        private void OpenDetails()
        {
            if (SelectedHall != null)
            {
                _navigationService.NavigateTo<HallDetailsPage>(SelectedHall.Id);
            }
        }
    }
}
