using LightCrm.Models;
using LightCrm.ViewModels;
using System.Windows;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window
    {
        public UserEditorWindow(UserAction action, ServiceReferenceUsers.UserDto user =null)
        {
            InitializeComponent();
            DataContext = new UserEditorWindowViewModel(action, user);
        }
    }
}
