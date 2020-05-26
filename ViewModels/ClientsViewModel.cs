
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

namespace ClientBase
{
    class ClientsViewModel
    {
        public ClientsViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Clients.Add(new Client() { Name = "111", City = "a1111", Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = "a1231", Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = "a2233", Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = "a1111", Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = "a1231", Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = "a2233", Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = "a1111", Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = "a1231", Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = "a2233", Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "111", City = "a1111", Note = "t12312" });
                Clients.Add(new Client() { Name = "222", City = "a1231", Note = "t22212" });
                Clients.Add(new Client() { Name = "333", City = "a2233", Note = "t33312" });
                Clients.Add(new Client() { Name = "444", City = "a4444", Note = "t44142" });
                Clients.Add(new Client() { Name = "555", City = "a4444", Note = "t44142" });
            }
        }

        public ObservableCollection<Client> Clients { get; } = new ObservableCollection<Client>();
    }
}
