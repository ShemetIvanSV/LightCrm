using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.ViewModels
{
    internal class UsersOrdersViewModel : BaseViewModel, IPageViewModel
    {
        #region Пробные данные 
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
        #endregion







        public UsersOrdersViewModel() 
        {
            Name = "Заказы";
        }
    }
}
