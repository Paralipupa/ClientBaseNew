
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
    class LoginViewModel : ViewModelBase
    {
        public LoginViewModel() { }

        public String Login { get; set; }

        public ICommand Enter
        {
            get
            {
                return new CommandBase(
                    parameter =>
                    {
                        PasswordBox box = parameter as PasswordBox;
                        String password = box.Password;

                        if (password == box.Password)
                        {
                            new ClientsWindow().Show();
                            Application.Current.Windows[0].Close();
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
            }
        }

        public ICommand Exit
        {
            get
            {
                return new CommandBase(
                    _ =>
                    {
                        Application.Current.Shutdown();
                    });
            }
        }
    }
}
