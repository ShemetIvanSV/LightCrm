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

        private  string _titel;

        public string Titel 
        {
            get => _titel;
            set
            {
                _titel = value;
                OnPropertyChanged();
            }
        }



        private int _Id;
        public int Id 
        {
            get => _Id;
            set 
            {
                _Id = value;
                OnPropertyChanged();
            }
        }


        private string _patient;
        public string Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged();
            }
        }


        private string _servise;
        public string Servise
        {
            get => _servise;
            set
            {
                _servise = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public ObservableCollection<ModelOrder> Orders { get; set; }




        public UsersOrdersViewModel() 
        {
            Orders = new ObservableCollection<ModelOrder> 
            {
                new ModelOrder {Id = 1, Patient="Tom", Servise = "Обсмотр"}
            
            };
            

            Name = "Заказы";
            Titel = "Страница заказов";
        }
    }
}
