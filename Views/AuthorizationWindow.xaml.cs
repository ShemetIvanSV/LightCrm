using LightCrm.ViewModels;
using System;
using System.Windows;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            var vm = new AuthorizationViewModel();
            DataContext = vm;

            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
