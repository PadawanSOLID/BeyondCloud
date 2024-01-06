using MahApps.Metro.Controls;
using Prism.Regions;
using BeyondCloud.Constants;
using BeyondCloud.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondCloud.Services
{
   public class SplitPaneService: ISplitPaneService
    {
        private SplitView splitView;

        private IRegionNavigationService _navigationService;
        public bool IsPaneOpen
        { 
            get => splitView.IsPaneOpen; 
            set => splitView.IsPaneOpen = value; 
        }
        public void Register(SplitView splitView)
        {
            this.splitView = splitView;
        }

        public SplitPaneService(IRegionManager regionManager)
        {
            _navigationService= regionManager.Regions[Regions.Pane].NavigationService;
        }

        public void Navigate(string page)
        {
            _navigationService.RequestNavigate(page);
        }
    }
}
