﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientBase
{
    public class BaseCommand : ICommand
    {
        private Action<Object> execute;
        private Func<Object, bool> can;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public BaseCommand(Action<Object> execute, Func<Object, bool> can = null)
        {
            this.execute = execute;
            this.can = can;
        }

        public bool CanExecute(Object parameter)
        {
            return can == null || can(parameter);
        }

        public void Execute(Object parameter)
        {
            execute(parameter);
        }
    }
}