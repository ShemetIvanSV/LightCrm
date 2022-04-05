using LightCrm.Commands;
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
        private ICommand _buttonCreateClickCommand;
        private ICommand _buttonEditeClickCommand;
        private ICommand _buttonDeleteClickCommand;
        
        public Action CloseAction { get; set; }
        
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private ServiceReferenceUsers.UserDto _user;
        public ServiceReferenceUsers.UserDto User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }

        private IEnumerable<ServiceReferenceUsers.UserDto> _userData;
        public IEnumerable<ServiceReferenceUsers.UserDto> UserData
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
                using (var service = new ServiceReferenceUsers.UsersServiceClient())
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

        public void ButtonCreateUserClick()
        {            
            var view = new UserEditorWindow(Models.UserAction.Create);
            view.ShowDialog();
        }

        public void ButtonEditUserClick()
        {
            if (User == null)
            {
                MessageBox.Show("Пользователь для редактирования не выбран!", "Внимание!");
                return;
            }
            var view = new UserEditorWindow(Models.UserAction.Edit, User);
            view.ShowDialog();
        }


        public void ButtonDeleteUserClick()
        {
            if (User==null)
            {
                MessageBox.Show("Пользователь для удаления не выбран!", "Внимание!");
                return;
            }

            var view = new UserEditorWindow(Models.UserAction.Delete, User);
            view.ShowDialog();
        }        
    }
}
