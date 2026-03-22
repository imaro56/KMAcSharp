using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using CinemaManager.Repositories.Interfaces;
using CinemaManager.Repositories.Implementations;
using CinemaManager.Services.Interfaces;
using CinemaManager.Services.Implementations;
using CinemaManager.WpfApp.Services;
using CinemaManager.WpfApp.ViewModels;
using CinemaManager.WpfApp.Pages;

namespace CinemaManager.WpfApp
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e) // init all services on startup
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            // Repositories
            services.AddSingleton<ICinemaHallRepository, CinemaHallRepository>();
            services.AddSingleton<IMovieSessionRepository, MovieSessionRepository>();

            // Services
            services.AddSingleton<ICinemaHallService, CinemaHallService>();
            services.AddSingleton<IMovieSessionService, MovieSessionService>();

            // navigation
            services.AddSingleton<NavigationService>();
            services.AddSingleton<INavigationService>(sp => sp.GetRequiredService<NavigationService>());

            // ViewModels
            services.AddTransient<HallListViewModel>();
            services.AddTransient<HallDetailsViewModel>();
            services.AddTransient<SessionDetailsViewModel>();

            // Pages
            services.AddTransient<HallsListPage>();
            services.AddTransient<HallDetailsPage>();
            services.AddTransient<SessionDetailsPage>();

            // MainWindow
            services.AddSingleton<MainWindow>();

            ServiceProvider = services.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}