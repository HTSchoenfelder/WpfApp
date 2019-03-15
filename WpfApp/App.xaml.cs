using WpfApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WpfApp.Services;
using Prism.Regions;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<AppConfigurationService>();
            containerRegistry.RegisterSingleton<RegionManager>();
            containerRegistry.Register<ILogger, Logger>();
        }
    }
}
