
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;
using System.Windows;
using System.Windows.Data;
using System.Management;

namespace ClientBase
{
    class AllClientsViewModel : ViewModel
    {
        private String searchedText;

        public AllClientsViewModel()
        {
            ClientsView = CollectionViewSource.GetDefaultView(Clients);
            ClientsView.Filter = FilterClients;

            LoadExampleData();
        }

        public ObservableCollection<Client> Clients { get; } = new ObservableCollection<Client>();
        public ICollectionView ClientsView { get; }
        public Client SelectedClient { get; set; }
        public String SearchedText
        {
            get
            {
                return searchedText;
            }
            set
            {
                if (Set(ref searchedText, value))
                {
                    ClientsView.Refresh();
                }
            }
        }

        public FilterParametersObject FilterParameters { get; set; } = new FilterParametersObject();
        public FilterViewModel FilterViewModel { get; set; }

        public ICommand Refresh => new Command(
            _ =>
            {
                ClientsView.Refresh();
                ClientsView.MoveCurrentTo(null);
            });

        public ICommand Add => new Command(
            _ =>
            {
            });

        public ICommand Edit => new Command(
            _ =>
            {
            },
            _ =>
            {
                return SelectedClient != null;
            });

        public ICommand Delete => new Command(
            _ =>
            {
            },
            _ =>
            {
                return SelectedClient != null;
            });

        public ICommand OpenFilterWindow => new Command(
            _ =>
            {
                if (FilterViewModel == null)
                {
                    WindowService.Instance.Show(FilterViewModel = new FilterViewModel(this), this);
                }
                else
                {
                    WindowService.Instance.Focus(FilterViewModel);
                }
            });

        public ICommand OpenSearchWindow => new Command(
            _ =>
            {
                WindowService.Instance.Show(new SearchViewModel(), this);
            });

        public bool FilterClients(Object item)
        {
            Client client = (Client) item;

            if (String.IsNullOrEmpty(SearchedText) == false)
            {
                if (client.Name.Contains(SearchedText) == false)
                {
                    return false;
                }
            }

            if (String.IsNullOrEmpty(FilterParameters.Var1) == false)
            {
                if (client.Name.Contains(FilterParameters.Var1) == false)
                {
                    return false;
                }
            }
            if (String.IsNullOrEmpty(FilterParameters.Var2) == false)
            {
                if (client.Name.Contains(FilterParameters.Var2) == false)
                {
                    return false;
                }
            }
            if (String.IsNullOrEmpty(FilterParameters.Var3) == false)
            {
                if (client.Name.Contains(FilterParameters.Var3) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public void LoadExampleData()
        {
            for (int i = 0; i < 1; i++)
            {
                Clients.Add(new Client() { Name = "111", City = new City() { Id = 1, Name = "City1" }, Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = new City() { Id = 1, Name = "City1" }, Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = new City() { Id = 1, Name = "City1" }, Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = new City() { Id = 1, Name = "City1" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = new City() { Id = 1, Name = "aity1" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = new City() { Id = 2, Name = "City2" }, Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = new City() { Id = 2, Name = "City2" }, Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = new City() { Id = 2, Name = "City4" }, Note = "t33312" });
                Clients.Add(new Client() { Name = "434", City = new City() { Id = 2, Name = "Cify2" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = new City() { Id = 2, Name = "City2" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = new City() { Id = 3, Name = "gdty2" }, Note = "t12312" });
                Clients.Add(new Client() { Name = "242", City = new City() { Id = 2, Name = "City2" }, Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = new City() { Id = 2, Name = "Chty2" }, Note = "t33312" });
                Clients.Add(new Client() { Name = "044", City = new City() { Id = 2, Name = "City2" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = new City() { Id = 3, Name = "city2" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = new City() { Id = 7, Name = "Cijy2" }, Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = new City() { Id = 6, Name = "City2" }, Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = new City() { Id = 5, Name = "Cigy2" }, Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = new City() { Id = 4, Name = "City2" }, Note = "t44142" });
                Clients.Add(new Client() { Name = "655", City = new City() { Id = 1, Name = "City2" }, Note = "t44142" });
            }
        }
    }
}
