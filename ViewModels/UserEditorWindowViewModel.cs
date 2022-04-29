using CrmModels;
using LightCrm.Commands;
using LightCrm.Models;
using LightCrm.ServiceReferenceRoles;
using LightCrm.ServiceReferenceDepartments;
using LightCrm.ServiceReferenceUsers;
using System;
using System.Collections.Generic;
using System.Linq;
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
                OnPropertyChanged("Title");
            }
        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _patronymic;
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
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
                OnPropertyChanged("PasswordConfirm");
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
                OnPropertyChanged("RoleData");
            }
        }

        private DepartmentDto _departmentDto;
        public DepartmentDto DepartmentDto
        {
            get => _departmentDto;
            set
            {
                _departmentDto = value;
            }
        }

        private IEnumerable<DepartmentDto> _departmentData;
        public IEnumerable<DepartmentDto> DepartmentData
        {
            get => _departmentData;
            set
            {
                _departmentData = value;
                OnPropertyChanged("DepartmentData");
            }
        }        

        private bool _isEnableLogin = false;
        public bool IsEnableLogin
        {

            get { return _isEnableLogin; }

            set
            {
                _isEnableLogin = value;
                OnPropertyChanged("IsEnableLogin");
            }
        }

        private bool _isEnableChecked;
        public bool IsEnableChecked 
        {

            get { return _isEnableChecked; }

            set
            {
                _isEnableChecked = value;
                OnPropertyChanged("IsEnableChecked");
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

        private bool _isCheckedPassword = false;
        public bool IsCheckedPassword
        {

            get { return _isCheckedPassword; }

            set
            {
                _isCheckedPassword = value;
                OnPropertyChanged("IsCheckedPassword");
            }
        }

        public UserEditorWindowViewModel(UserAction title, IEnumerable<RoleDto> roleData, IEnumerable<DepartmentDto> departmentData, UserDto userDto)
        {
            switch (title)
            {
                case UserAction.Create:
                    Title = "Создание пользователя";
                    IsEnable = true;
                    IsEnableLogin = true;
                    IsCheckedPassword = true;
                    IsEnableChecked = false;
                    ButtonOk = "Сохранить";
                    break;

                case UserAction.Edit:
                    Title = "Редактирование пользователя";
                    IsEnable = true;
                    IsEnableLogin = false;
                    IsCheckedPassword = false;
                    IsEnableChecked = true;
                    ButtonOk = "Сохранить";
                    break;

                case UserAction.Delete:
                    Title = "Удаление пользователя";
                    IsEnable = false;
                    IsEnableLogin = false;
                    IsCheckedPassword = false;
                    IsEnableChecked = false;
                    ButtonOk = "Удалить";
                    break;
            }

            GetRoleData();
            GetDepartmentData();

            if (userDto == null)
            {
                return;
            }

            UserDto = userDto;
            Username = userDto.Username;
            Name = userDto.Name;
            Surname = userDto.Surname;
            Patronymic = userDto.Patronymic;
            RoleDto = RoleData.Where(i => i.Id == UserDto.Role.Id).FirstOrDefault();
            DepartmentDto = DepartmentData.Where(i => i.Id == UserDto.Department.Id).FirstOrDefault();    
        }

        private void GetDepartmentData()
        {
            try
            {
                using (var service = new DepartmentServiceClient())
                {
                    DepartmentData = service.GetDepartments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                            if (service.GetUsers().Select(n => n.Username).Contains(Username))
                            {
                                throw new Exception("Этот логин уже занят");
                            }

                            if (RoleDto == null)
                            {
                                throw new Exception("Выберите роль пользователя");
                            }

                            if (String.IsNullOrEmpty(Password))
                            {
                                throw new Exception("Пароль не может быть пустым");
                            }

                            if (Password != _passwordConfirm)
                            {
                                throw new Exception("Подтверждение пароля не совпадает");
                            }

                            UserDto = new UserDto()
                            {
                                Name = Name,
                                Password = Password,
                                Username = Username,
                                Surname = Surname,
                                Patronymic = Patronymic,
                                Department = DepartmentDto,
                                Role = RoleDto,
                                Timetables = new List<TimetablesDto>(),//TODO
                            };

                            service.AddNewUser(UserDto);
                            
                            GetRoleData();
                            CloseAction();
                            break;

                        case "Редактирование пользователя":
                            if (RoleDto == null)
                            {
                                throw new Exception("Выберите роль пользователя");
                            }                            

                            UserDto.Name = Name;                            
                            UserDto.Password = Password;
                            UserDto.Username = Username;
                            UserDto.Surname = Surname;
                            UserDto.Patronymic = Patronymic;                            
                            UserDto.Department = DepartmentDto;
                            UserDto.Role = RoleDto;
                            UserDto.Timetables = new List<TimetablesDto>();//TODO
                                                        
                            service.UpdateUser(UserDto);

                            if (IsCheckedPassword)
                            {
                                if (String.IsNullOrEmpty(Password))
                                {
                                    throw new Exception("Пароль не может быть пустым");
                                }

                                if (Password != _passwordConfirm)
                                {
                                    throw new Exception("Подтверждение пароля не совпадает");
                                }

                                service.UpdateUserPassword(UserDto);
                            }

                            GetRoleData();
                            CloseAction();
                            break;

                        case "Удаление пользователя":
                            service.DeleteUser(UserDto);
                            GetRoleData();
                            CloseAction();
                            break;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
