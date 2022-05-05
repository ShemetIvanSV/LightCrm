using LightCrm.Commands;
using LightCrm.DepartmentService;
using LightCrm.RolesService;
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

        private UserDto _userDto;
        public UserDto UserDto
        {
            get => _userDto;
            set
            {
                _userDto = value;
            }
        }

        private IEnumerable<UserDto> _userData;
        public IEnumerable<UserDto> UserData
        {
            get => _userData;
            set
            {
                _userData = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public UsersAdministrationViewModel()
        {
            Name = "Пользователи";
            GetUserData();
            GetRoleData();
            GetDepartmentData();
        }

        private void GetUserData(object obj = null)
        {
            try
            {
                using (var service = new UsersServiceClient())
                {
                    UserData = service.GetUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetRoleData()
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
            var view = new UserEditorWindow(Models.UserAction.Create, RoleData, DepartmentData);
            view.ShowDialog();
            GetUserData();
        }

        public void ButtonEditUserClick()
        {
            if (UserDto == null)
            {
                MessageBox.Show("Пользователь для редактирования не выбран!", "Внимание!");
                return;
            }
            var view = new UserEditorWindow(Models.UserAction.Edit, RoleData, DepartmentData, UserDto);
            view.ShowDialog();
            GetUserData();
        }


        public void ButtonDeleteUserClick()
        {
            if (UserDto == null)
            {
                MessageBox.Show("Пользователь для удаления не выбран!", "Внимание!");
                return;
            }

            var view = new UserEditorWindow(Models.UserAction.Delete, RoleData, DepartmentData, UserDto);
            view.ShowDialog();
            GetUserData();
        }
    }
}
