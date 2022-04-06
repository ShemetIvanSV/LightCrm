﻿using CrmModels;
using LightCrm.Commands;
using LightCrm.Models;
using LightCrm.ServiceReferenceRoles;
using LightCrm.ServiceReferenceUsers;
using LightCrm.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна редактирования пользователей
    /// </summary>
    public class UserEditorWindowViewModel : BaseViewModel, IPageViewModel
    {
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

        private string _passwordConfirm;
        public string PasswordConfirm
        {
            get => _passwordConfirm;
            set
            {
                _passwordConfirm = value;
                OnPropertyChanged();
            }
        }

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

        private UserDto _user;
        public UserDto User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }

        private RoleDto _role;
        public RoleDto Role
        {
            get => _role;
            set
            {
                _role = value;
            }
        }

        private bool _isEnable = false;
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

        private IEnumerable<RoleDto> _roleData;
        public IEnumerable<RoleDto> RoleData
        {
            get => _roleData;
            set
            {
                _roleData = value;
                OnPropertyChanged();
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

            GetRoleData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }

        private void GetRoleData(object obj = null)
        {
            try
            {
                using (var service = new RolesServiceClient())
                {
                    RoleData = service.GetRoles();
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

            try 
            {
                using (var service = new UsersServiceClient())
                {
                    switch (Name)
                    {
                        case "Создание пользователя":
                            User = new UserDto()
                            {
                                Name = "1",
                                Password = "2",
                                Username = "3",
                                Surname = "4",
                                Patronymic = "5",
                                Department = new DepartmentDto() { Id = 1 },
                                Role = new RoleDto() { Id = 1 },
                                Timetables = new List<TimetablesDto>(),
                            };
                            service.AddNewUser(User);
                            break;
                        case "Редактирование пользователя":
                            service.UpdateUser(User);
                            break;
                        case "Удаление пользователя":
                            service.DeleteUser(User);
                            break;
                    }

                    GetRoleData();

                    UserEditorWindow.Owner.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }
    }
}