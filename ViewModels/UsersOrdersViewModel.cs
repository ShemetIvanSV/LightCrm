using LightCrm.Commands;
using LightCrm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.ViewModels
{
    public class UsersOrdersViewModel : BaseViewModel, IPageViewModel
    {

        #region Пробные данные 
        private ObservableCollection<ModelOrder> _orders;
        public ObservableCollection<ModelOrder> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged();
            }
        }

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
        
        
        #region Выделение заказа
        private ModelOrder _selectedOrder;
        public ModelOrder SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }
        #endregion

        #region Команда Добавление закакза 
        private RelayCommand _addOrderCommand;
        public RelayCommand AddOrderCommand
        {
            get
            {
                return _addOrderCommand ??
                  (_addOrderCommand = new RelayCommand(obj =>
                  {
                      ModelOrder order = new ModelOrder()
                      {
                          //Id = 1 ,
                          //Patient = "Tom",
                          //Servise = "Обсмотр",
                          //Date = DateTime.Now,
                          //Doctor = "Bob",
                          //Paid = "no",
                          //Price = 1000,
                          //Status = "Complited"
                      };
                      Orders.Insert(0, order);
                  }));
            }
        }

        #endregion
        #region Команда удаление заказа
        private RelayCommand _removeOrderCommand;
        public RelayCommand RemoveOrderCommand
        {
            get
            {
                return _removeOrderCommand ??
                    (_removeOrderCommand = new RelayCommand(obj =>
                    {
                        if (obj is ModelOrder order)
                        {
                            Orders.Remove(order);
                        }
                    },
                    (obj) => Orders.Count > 0));
            }
        }
        #endregion
        #region Команда Открытия окна 
        public OpenWindowCommand OpenWindowCommand { get; private set; }

        #endregion


        public UsersOrdersViewModel() 
        {
            Orders = new ObservableCollection<ModelOrder> 
            {
                
                //new ModelOrder {Id = 1, Patient="Tom", Servise = "Обсмотр", Date=DateTime.Now, Doctor="Bob", Paid="no", Price=1000, Status="Complited"} // тестовые данные
                
            };
           
            OpenWindowCommand = new OpenWindowCommand();
            Name = "Заказы";
            Title = "Страница заказов";
         /*using (var client = new ServiceClient())
           {
               client.AddNewService(new ServiceDto());

           }
         */
        }
    }
}


