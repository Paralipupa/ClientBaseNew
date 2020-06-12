
using ClientBase.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClientBase
{
    class LoginViewModel : ViewModel
    {
        public LoginViewModel() { }

        public String Login { get; set; }

        public ICommand Enter => new Command(
            parameter =>
            {
                PasswordBox box = parameter as PasswordBox;
                String password = box.Password;

                if (password == box.Password)
                {
                    WindowService windows = WindowService.Instance;
                    windows.Show(new AllClientsViewModel());
                    windows.Close(this);
                }
                else
                {
                    _ = MessageBox.Show("Неправильно указан логин или пароль.", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            _ =>
            {
                return String.IsNullOrWhiteSpace(Login) == false;
            });

        public ICommand Exit => new Command(
            _ =>
            {
                WindowService.Instance.Close(this);
            });
    }
}
