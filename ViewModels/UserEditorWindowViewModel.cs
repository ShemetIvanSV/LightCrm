using LightCrm.Commands;
using LightCrm.ServiceReference;
using System.Windows;
using System.Windows.Input;
using LightCrm.Views;
using LightCrm.Models;
using System;
using System.Windows.Controls;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна редактирования пользователей
    /// </summary>
    public class UserEditorWindowViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        private UserDto _user;
        private bool _isEnable = false;        
        private string _buttonOk;

        private ICommand _buttonOkClickCommand;


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

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public UserDto User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }

        public bool IsEnable
        {

            get { return _isEnable; }

            set
            {
                _isEnable = value;
                OnPropertyChanged("IsEnable");
            }
        }

        public string ButtonOk
        {

            get { return _buttonOk; }

            set
            {
                _buttonOk = value;
                OnPropertyChanged("ButtonOk");
            }
        }

        public UserEditorWindowViewModel(UserAction name, UserDto user)
        {
            switch (name)
            {
                case UserAction.Create:
                    Name = "Создание пользователя";
                    IsEnable = true;
                    ButtonOk = "Сохранить";
                    break;
                case UserAction.Edit:
                    Name = "Редактирование пользователя";
                    IsEnable = true;
                    ButtonOk = "Сохранить";
                    break;
                case UserAction.Delete:
                    Name = "Удаление пользователя";
                    IsEnable = false;
                    ButtonOk = "Удалить";
                    break;
            }

            User = user;
            if (user==null)
            {                
                return;
            }

            //GetUserData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }
                
        public ICommand ButtonOkClickCommand
        {
            get
            {
                /*if (_buttonOkClickCommand == null)
                {
                    _buttonOkClickCommand = new RelayCommand(p => ButtonOkClick());                    
                }*/

                _buttonOkClickCommand = new RelayCommand(ButtonOkClick);

                return _buttonOkClickCommand;
            }
        }

        public void ButtonOkClick(object commandParameter)
        {
            Password = ((PasswordBox)commandParameter).Password;
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пароль не может быть пустым", "Внимание!");
                return;
            }
            MessageBox.Show("Ok, password = " + Password);
            
        }
    }
}
