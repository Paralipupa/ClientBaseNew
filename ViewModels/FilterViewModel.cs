
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

        public ICommand CloseWindow => new Command(
            _ =>
            {
                AllClientsViewModel.FilterViewModel = null;
            });
    }
}
