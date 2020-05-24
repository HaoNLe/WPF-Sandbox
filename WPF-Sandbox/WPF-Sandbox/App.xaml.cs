using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using WPF_Sandbox.ViewModels;

namespace WPF_Sandbox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            var window = Container.Resolve<MainWindow>();
            window.DataContext = Container.Resolve<MainWindowViewModel>();
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule(typeof(MainModule));
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            IRegionManager RegionManager = Container.Resolve<IRegionManager>();
            RegionManager.RequestNavigate(Navigation.MainWindowRegion, Navigation.SandboxView);
        }

    }
}
