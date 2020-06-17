
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
            FilterParameters = parent.FilterParameters.Clone() as FilterParametersObject;
        }

        public AllClientsViewModel AllClientsViewModel { get; set; }
        public FilterParametersObject FilterParameters { get; set; }

        public ICommand Filter => new Command(
            _=>
            {
                AllClientsViewModel.FilterParameters = FilterParameters.Clone() as FilterParametersObject;
                AllClientsViewModel.ClientsView.Refresh();
            });

        public ICommand Clear => new Command(
            _ =>
            {
                FilterParameters = new FilterParametersObject();
                AllClientsViewModel.FilterParameters = FilterParameters.Clone() as FilterParametersObject;
                AllClientsViewModel.ClientsView.Refresh();
            });

        public ICommand CloseWindow => new Command(
            _ =>
            {
                AllClientsViewModel.FilterViewModel = null;
            });
    }

    class FilterParametersObject : ObservableObject, ICloneable
    {
        public FilterParametersObject()
        {
            Var1 = "";
            Var2 = "";
            Var3 = "";
        }

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

        public Object Clone()
        {
            FilterParametersObject filter = new FilterParametersObject();

            filter.Var1 = String.Copy(Var1);
            filter.Var2 = String.Copy(Var2);
            filter.Var3 = String.Copy(Var3);

            return filter;
        }
    }
}
