
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace ClientBase
{
    public class DataGridBehavior : Behavior<DataGrid>
    {
        public static readonly DependencyProperty SelectedItemsProperty =
                  DependencyProperty.Register(
                      "SelectedItems",
                      typeof(INotifyCollectionChanged),
                      typeof(DataGridBehavior),
                      new FrameworkPropertyMetadata(null));

        public INotifyCollectionChanged SelectedItems
        {
            get { return (INotifyCollectionChanged) GetValue(SelectedItemsProperty); }
            set { SetValue(SelectedItemsProperty, value); }
        }

        public DataGrid DataGrid => AssociatedObject;

        protected override void OnAttached()
        {
            base.OnAttached();
            DataGrid.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            DataGrid.SelectionChanged -= OnSelectionChanged;
        }

        public void OnSelectionChanged(Object sender, SelectionChangedEventArgs args)
        {
            IList items = SelectedItems as IList;

            foreach (Client item in args.AddedItems)
            {
                items.Add(item);
            }

            foreach (Client item in args.RemovedItems)
            {
                items.Remove(item);
            }
        }
    }
}
