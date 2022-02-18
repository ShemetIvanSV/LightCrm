using LightCrm.ServiceReference;
using LightCrm.ViewModels;
using System.Windows;

namespace LightCrm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(UserDto user)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(user);
        }
    }
}
