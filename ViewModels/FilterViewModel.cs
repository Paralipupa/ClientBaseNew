
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientBase
{
    class FilterViewModel : ViewModel
    {
        public FilterViewModel(AllClientsViewModel parent)
        {
            AllClientsViewModel = parent;
        }

        public AllClientsViewModel AllClientsViewModel { get; set; }

        public ICommand Filter => new Command(
            _=>
            {
                AllClientsViewModel.ClientsView.Refresh();
            });

        public ICommand Clear => new Command(
            _ =>
            {
                AllClientsViewModel.FilterParameters = new FilterParametersObject();
                AllClientsViewModel.ClientsView.Refresh();
            });

        public ICommand CloseWindow => new Command(
            _ =>
            {
                AllClientsViewModel.FilterViewModel = null;
            });
    }

    class FilterParametersObject : ObservableObject
    {
        public String Var1 { get; set; }
        public String Var2 { get; set; }
        public String Var3 { get; set; }

        public bool IsClear
        {
            get
            {
                return String.IsNullOrEmpty(Var1) && String.IsNullOrEmpty(Var2) && String.IsNullOrEmpty(Var3);
            }
        }
    }
}
