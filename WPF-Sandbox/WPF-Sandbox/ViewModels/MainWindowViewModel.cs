using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;

namespace WPF_Sandbox.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        public IRegionManager RegionManager
        {
            get { return _regionManager; }
            set { SetProperty(ref _regionManager, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }
    }
}
