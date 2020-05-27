﻿
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

        public ObservableCollection<Client> Clients { get; } = new ObservableCollection<Client>();
    }
}