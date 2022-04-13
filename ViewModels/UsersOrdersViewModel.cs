﻿namespace LightCrm.ViewModels
{
    internal class UsersOrdersViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;

        public string Title 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public UsersOrdersViewModel() 
        {
            Title = "Заказы";
        }
    }
}
