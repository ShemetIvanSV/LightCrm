using LightCrm.ViewModels;
using System.Windows.Controls;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class UserAdministrationPage : ContentControl
    {
        public UserAdministrationPage()
        {
            InitializeComponent();
            DataContext = new UsersAdministrationViewModel();
        }
    }
}
