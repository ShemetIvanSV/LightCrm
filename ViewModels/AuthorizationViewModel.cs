using LightCrm.Commands;
using LightCrm.ServiceReferenceUsers;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна авторизации
    /// </summary>
    public class AuthorizationViewModel : BaseViewModel
    {
        private ICommand _loginCommand;

        public Action CloseAction { get; set; }

        public ICommand LoginCommand { get => _loginCommand; }


        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public AuthorizationViewModel()
        {
            _loginCommand = new RelayCommand(Authorization);
        }

        private void Authorization(object commandParameter)
        {
            try
            {
                using (var service = new UsersServiceClient())
                {
                    Password = ((PasswordBox)commandParameter).Password;
                    var user = service.GetUserByLoginData(Login, Password);
                    var view = new MainWindow(user);
                    view.Show();
                    CloseAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
