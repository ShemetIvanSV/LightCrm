using LightCrm.Commands;
using LightCrm.ServiceReference;
using LightCrm.Views;
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
                        p => ButtonCreateUserClick());
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
                        p => ButtonEditUserClick());
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
                        p => ButtonDeleteUserClick());
                }

                return _buttonDeleteClickCommand;
            }
        }

        public void ButtonCreateUserClick(UserDto user=null)
        {
            var view = new UserEditorWindow("Создать пользователя", user);
            view.ShowDialog();
            //CloseAction();
        }

        public void ButtonEditUserClick(UserDto user = null)
        {
            if (user == null)
            {
                MessageBox.Show("Пользователь для редактирования не выбран!", "Внимание!");
                return;
            }
            var view = new UserEditorWindow("Редактировать пользователя", user);
            view.ShowDialog();
            //CloseAction();
        }


        public void ButtonDeleteUserClick(UserDto user = null)
        {
            if (user==null)
            {
                MessageBox.Show("Пользователь для удаления не выбран!", "Внимание!");
                return;
            }
            var view = new UserEditorWindow("Удалить пользователя", user);
            view.ShowDialog();
            //CloseAction();
        }        
    }
}
