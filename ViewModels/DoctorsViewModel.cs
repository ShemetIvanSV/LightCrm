using LightCrm.Commands;
using LightCrm.Models;
using System;
using System.Collections.ObjectModel;

namespace LightCrm.ViewModels
{
    public class DoctorsViewModel : BaseViewModel, IPageViewModel
    {
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

        private string _diagnosis;   //диагноз
        public string Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged();
            }
        }

        private string _medicines;  //препараты
        public string Medicines
        {
            get => _medicines;
            set
            {
                _medicines = value;
                OnPropertyChanged();
            }
        }

        private string _treatment;  //лечение
        public string Treatment
        {
            get => _treatment;
            set
            {
                _treatment = value;
                OnPropertyChanged();
            }
        }

    }
}
