
using ClientBase.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBase
{
    public partial class App : Application
    {
        public App()
        {
            InitWindowService();
        }

        private void StartupApp(Object sender, StartupEventArgs args)
        {
            WindowService.Instance.Show(new LoginViewModel());
        }

        private void InitWindowService()
        {
            WindowService windows = WindowService.Instance;
            windows.Register<AboutViewModel, AboutWindow>();
            windows.Register<AllClientsViewModel, AllClientsWindow>();
            windows.Register<ClientViewModel, ClientWindow>();
            windows.Register<FilterViewModel, FilterWindow>();
            windows.Register<LoginViewModel, LoginWindow>();
            windows.Register<SearchViewModel, SearchWindow>();
        }
    }
}
