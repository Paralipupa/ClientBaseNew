
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBase
{
    class WindowService
    {
        public static WindowService Instance { get; } = new WindowService();

        private WindowService() { }

        private Dictionary<Type, Type> ViewModelToWindowMap { get; set; } = new Dictionary<Type, Type>();
        private Dictionary<Object, Window> OpenWindows { get; } = new Dictionary<Object, Window>();

        public void Register<VM, W>() where W : Window, new() where VM : class
        {
            ViewModelToWindowMap.Add(typeof(VM), typeof(W));
        }

        public void Unregister<VM>()
        {
            ViewModelToWindowMap.Remove(typeof(VM));
        }

        public void Show(Object viewmodel)
        {
            Window window = CreateWindow(viewmodel);
            window.Show();
        }

        public void ShowModal(Object viewmodel)
        {
            Window window = CreateWindow(viewmodel);
            window.ShowDialog();
        }

        public void Close(Object viewmodel)
        {
            Window window = OpenWindows[viewmodel];
            window.Close();
        }

        public Window CreateWindow(Object viewmodel)
        {
            Window window = (Window) Activator.CreateInstance(ViewModelToWindowMap[viewmodel.GetType()]);
            window.DataContext = viewmodel;
            window.Loaded += (s, a) => { OpenWindows.Add(viewmodel, window); };
            window.Closed += (s, a) => { OpenWindows.Remove(viewmodel); };
            return window;
        }
    }
}
