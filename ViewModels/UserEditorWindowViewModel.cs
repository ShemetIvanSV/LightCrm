using LightCrm.Commands;
using LightCrm.ServiceReference;
using System.Windows;
using System.Windows.Input;
using LightCrm.Views;
using LightCrm.Models;
using System;

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
        private ICommand _buttonOkClickCommand;
        private string _buttonOk;

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
                if (_buttonOkClickCommand == null)
                {
                    _buttonOkClickCommand = new RelayCommand(
                        p => ButtonOkClick());
                }

                return _buttonOkClickCommand;
            }
        }

        public void ButtonOkClick(UserDto user = null)
        {
            MessageBox.Show("Ok");
        }
    }
}
