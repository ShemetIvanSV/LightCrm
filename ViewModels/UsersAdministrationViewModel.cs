using LightCrm.Commands;
using LightCrm.ServiceReference;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления страницы работы с пользователями
    /// </summary>
    public class UsersAdministrationViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        private IEnumerable<UserDto> _userData;
        //private ICommand _dataBaseReadCommand;
        private ICommand _buttonCreateClickCommand;
        private ICommand _buttonEditeClickCommand;
        private ICommand _buttonDeleteClickCommand;
        
        public Action CloseAction { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<UserDto> UserData
        {
            get => _userData;
            set
            {
                _userData = value;
                OnPropertyChanged();                
            }
        }

        public UsersAdministrationViewModel()
        {
            Name = "Пользователи";
            GetUserData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }

        private void GetUserData(object obj = null)
        {
            try
            {
                using (var service = new UsersServiceClient())
                {
                    UserData = service.GetUsers();
                    //var view = new MainWindow(user);
                    //view.Show();
                    //CloseAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ICommand ButtonCreateClickCommand
        {
            get
            {
                if (_buttonCreateClickCommand == null)
                {
                    _buttonCreateClickCommand = new RelayCommand(
                        p => ButtonCreateClick());
                }

                return _buttonCreateClickCommand;
            }
        }

        public ICommand ButtonEditClickCommand
        {
            get
            {
                if (_buttonEditeClickCommand == null)
                {
                    _buttonEditeClickCommand = new RelayCommand(
                        p => ButtonEditClick());
                }

                return _buttonEditeClickCommand;
            }
        }

        public ICommand ButtonDeleteClickCommand
        {
            get
            {
                if (_buttonDeleteClickCommand == null)
                {
                    _buttonDeleteClickCommand = new RelayCommand(
                        p => ButtonDeleteClick());
                }

                return _buttonDeleteClickCommand;
            }
        }

        public void ButtonCreateClick()
        {
            MessageBox.Show("Create");
        }

        public void ButtonEditClick()
        {
            MessageBox.Show("Edit");
        }


        public void ButtonDeleteClick()
        {
            MessageBox.Show("Delete");
        }        
    }
}
