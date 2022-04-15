using CrmModels;
using LightCrm.Commands;
using LightCrm.Models;
using LightCrm.ServiceReferenceRoles;
using LightCrm.ServiceReferenceUsers;
using LightCrm.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;


namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна редактирования пользователей
    /// </summary>
    public class UserEditorWindowViewModel : BaseViewModel, IPageViewModel
    {
        public Action CloseAction { get; set; }

        private ICommand _buttonOkClickCommand;

        private string _buttonOk;
        public string ButtonOk
        {

            get { return _buttonOk; }

            set
            {
                _buttonOk = value;
                OnPropertyChanged("ButtonOk");
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
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

        private string _patronymic;
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
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

        private string _passwordConfirm;
        private string _passwordDisplayed
        {
            get => new string('*', _passwordConfirm == null ? 0 : _passwordConfirm.Length);
        }
        public string PasswordConfirm
        {
            get => _passwordDisplayed;
            set
            {
                _passwordConfirm = value;
                OnPropertyChanged();
            }
        }

        private UserDto _userDto;
        public UserDto UserDto
        {
            get => _userDto;
            set
            {
                _userDto = value;
            }
        }

        private RoleDto _roleDto;
        public RoleDto RoleDto
        {
            get => _roleDto;
            set
            {
                _roleDto = value;
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

        public UserEditorWindowViewModel(UserAction title, UserDto userDto)
        {
            switch (title)
            {
                case UserAction.Create:
                    Title = "Создание пользователя";
                    IsEnable = true;
                    ButtonOk = "Сохранить";
                    break;

                case UserAction.Edit:
                    Title = "Редактирование пользователя";
                    IsEnable = true;
                    ButtonOk = "Сохранить";
                    break;

                case UserAction.Delete:
                    Title = "Удаление пользователя";
                    IsEnable = false;
                    ButtonOk = "Удалить";
                    break;
            }

            if (userDto == null)
            {
                return;
            }

            UserDto = userDto;
            Username = userDto.Username;
            Name = userDto.Name;
            Surname = userDto.Surname;
            Patronymic = userDto.Patronymic;
            //Department = userDto.Department;
            //Role = userDto.Role;


            //GetRoleData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }

        private void GetRoleData(object obj = null)
        {
            try
            {
                using (var service = new RolesServiceClient())
                {
                    RoleData = service.GetRoles();
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
                _buttonOkClickCommand = new RelayCommand(ButtonOkClick);

                return _buttonOkClickCommand;
            }
        }

        public void ButtonOkClick(object commandParameter)
        {
            Password = ((PasswordBox)commandParameter).Password;

            try
            {
                using (var service = new UsersServiceClient())
                {
                    switch (Title)
                    {
                        case "Создание пользователя":
                            UserDto = new UserDto()
                            {
                                Name = Name,
                                Password = Password,
                                Username = Username,
                                Surname = Surname,
                                Patronymic = Patronymic,
                                //TODO
                                Department = new DepartmentDto() { Id = 1 },
                                Role = new RoleDto() { Id = 1 },
                                Timetables = new List<TimetablesDto>(),
                            };

                            if (!PasswordVerify())
                            {
                                break;
                            }

                            service.AddNewUser(UserDto);
                            break;

                        case "Редактирование пользователя":
                            UserDto.Name = Name;
                            UserDto.Password = Password;
                            UserDto.Username = Username;
                            UserDto.Surname = Surname;
                            UserDto.Patronymic = Patronymic;
                            //TODO
                            UserDto.Department = new DepartmentDto() { Id = 1 };
                            UserDto.Role = new RoleDto() { Id = 1 };
                            UserDto.Timetables = new List<TimetablesDto>();

                            if (!PasswordVerify())
                            {
                                break;
                            }

                            service.UpdateUser(UserDto);
                            break;

                        case "Удаление пользователя":
                            service.DeleteUser(UserDto);
                            break;
                    }

                    GetRoleData();
                    CloseAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool PasswordVerify()
        {
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Пароль не может быть пустым", "Внимание!");
                return false;
            }

            if (Password != _passwordConfirm)
            {
                MessageBox.Show("Подтверждение пароля не совпадает", "Внимание!");
                return false;
            }

            return true;
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }
    }
}
