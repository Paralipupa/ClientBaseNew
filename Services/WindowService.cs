﻿
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
        private Dictionary<ViewModelBase, Window> OpenWindows { get; } = new Dictionary<ViewModelBase, Window>();

        public void Register<VM, W>() where W : Window, new() where VM : class
        {
            ViewModelToWindowMap.Add(typeof(VM), typeof(W));
        }

        public void Unregister<VM>()
        {
            ViewModelToWindowMap.Remove(typeof(VM));
        }

        public void Show(ViewModelBase child, ViewModelBase owner = null)
        {
            Window window = CreateWindow(child, owner);
            window.Show();
        }

        public void ShowModal(ViewModelBase viewmodel)
        {
            Window window = CreateWindow(viewmodel);
            window.ShowDialog();
        }

        public void Close(ViewModelBase viewmodel)
        {
            Window window = OpenWindows[viewmodel];
            window.Close();
        }

        public Window CreateWindow(ViewModelBase child, ViewModelBase owner = null)
        {
            Window window = (Window) Activator.CreateInstance(ViewModelToWindowMap[child.GetType()]);
            window.DataContext = child;
            window.Owner = owner != null ? OpenWindows[owner] : null;
            window.Loaded += (s, a) => { OpenWindows.Add(child, window); };
            window.Closed += (s, a) => { OpenWindows.Remove(child); };
            return window;
        }
    }
}
