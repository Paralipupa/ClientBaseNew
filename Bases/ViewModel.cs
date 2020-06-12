
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBase
{
    abstract class ViewModel : ObservableObject
    {
        public bool IsInDesignMode { get; } = DesignerProperties.GetIsInDesignMode(new DependencyObject());
    }
}
