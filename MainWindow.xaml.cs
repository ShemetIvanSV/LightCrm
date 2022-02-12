using LightCrm.ServiceReference;
using System.Windows;

namespace LightCrm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var service = new UsersServiceClient())
            {
                service.AddNewUser(new UserDto
                {
                    Name = "Test",
                    Password = "Test"
                });
            }
        }
    }
}
