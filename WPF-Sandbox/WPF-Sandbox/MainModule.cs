using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Infrastructure;
using WPF_Sandbox.ViewModels;
using WPF_Sandbox.Views;

namespace WPF_Sandbox
{
    class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register for navigation
            containerRegistry.RegisterForNavigation<SandboxView, SandboxViewModel>(Navigation.SandboxView);

            // Register services
        }
    }
}
