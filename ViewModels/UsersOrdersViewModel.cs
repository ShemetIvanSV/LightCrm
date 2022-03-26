using LightCrm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.ViewModels
{
    internal class UsersOrdersViewModel : BaseViewModel, IPageViewModel
    {
        public ObservableCollection<ModelOrder> Orders { get; set; }

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

        private  string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        #endregion

        




        public UsersOrdersViewModel() 
        {
            Orders = new ObservableCollection<ModelOrder> 
            {
                new ModelOrder {Id = 1, Patient="Tom", Servise = "Обсмотр", Date=DateTime.Now, Doctor="Bob", Paid="no", Price=1000, Status="Complited"} // тестовые данные
                
            };
            

            Name = "Заказы";
            Title = "Страница заказов";
        }
    }
}
