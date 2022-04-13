using CrmModels;
using LightCrm.Models;
using LightCrm.ViewModels;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window
    {
        public UserEditorWindow(UserAction action, UserDto userDto = null)
        {
            InitializeComponent();
            var vm = new UserEditorWindowViewModel(action, userDto);
            DataContext = vm;

            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
