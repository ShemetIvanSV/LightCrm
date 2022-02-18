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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LightCrm.ViewModels;

namespace LightCrm.Views
{
    /// <summary>
    /// Логика взаимодействия для UserOrderPage.xaml
    /// </summary>
    public partial class UserOrderPage : ContentControl
    {
        public UserOrderPage()
        {
            InitializeComponent();
            DataContext = new UsersOrdersViewModel();
        }
    }
}
