using Microsoft.Extensions.DependencyInjection;
using CinemaManager.Services;
using System.Windows;

namespace CinemaManager.WpfApp
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ICinemaService, CinemaService>();
            serviceCollection.AddSingleton<MainWindow>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
