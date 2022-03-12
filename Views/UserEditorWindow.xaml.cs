using LightCrm.ServiceReference;
using LightCrm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window
    {
        public UserEditorWindow(string action, UserDto user=null)
        {
            InitializeComponent();
            DataContext = new UserEditorWindowViewModel(action, user);
        }
    }
}
