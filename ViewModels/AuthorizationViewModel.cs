using LightCrm.Commands;
using System;
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

        public AuthorizationViewModel()
        {
            _loginCommand = new RelayCommand(Login);
        }

        private void Login(object obj = null)
        {
            //TODO: логика авторизации
            //Делаем грязь, чтобы сильно не заморачиваться
            var view = new MainWindow();
            view.Show();
            CloseAction();
        }
    }
}
