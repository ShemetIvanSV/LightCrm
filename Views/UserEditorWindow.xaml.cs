using CrmModels;
using LightCrm.Models;
using LightCrm.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LightCrm.Views
{
    /// <summary>1
    /// Логика взаимодействия для UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window
    {
        public UserEditorWindow(UserAction action, IEnumerable<RoleDto> roleData, IEnumerable<DepartmentDto> departmentData, UserDto userDto = null)
        {
            InitializeComponent();
            var vm = new UserEditorWindowViewModel(action, roleData, departmentData, userDto);
            DataContext = vm;

            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
