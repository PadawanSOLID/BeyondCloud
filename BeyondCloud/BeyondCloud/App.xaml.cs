using Prism.Ioc;
using Prism.Unity;
using BeyondCloud.Constants;
using BeyondCloud.ViewModels.ListViewModels;
using BeyondCloud.ViewModels;
using BeyondCloud.Views.ListViews;
using BeyondCloud.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BeyondCloud
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //#if DEBUG
            //            return new TravelWindow();
            //#else
            var login = Container.Resolve<LoginWindow>();
            var result = login.ShowDialog();
            if (result is null || !result.Value)
            {
                App.Current.Shutdown();
                return null;
            }
            else
            {
                ShutdownMode = ShutdownMode.OnMainWindowClose;
                return Container.Resolve<ShellWindow>();
            }
            //#endif
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<LoginWindow>();
            containerRegistry.Register<LoginWindowViewModel>();
            containerRegistry.RegisterForNavigation<ShellWindow, ShellWindowViewModel>();
            containerRegistry.RegisterForNavigation<MachineListView, MachineListViewModel>(ListPages.Machine);
            containerRegistry.RegisterForNavigation<AlarmLightsView, AlarmLightsViewModel>(ListPages.Alarm);
            containerRegistry.RegisterForNavigation<MachineDetailView, MachineDetailViewModel>(DetailPages.Machine);
        }
    }

}
