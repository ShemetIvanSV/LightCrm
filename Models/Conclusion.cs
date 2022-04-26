using LightCrm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.Models
{
    public class Conclusion : BaseViewModel
    {
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

        private List<string> _medicines;  //препараты
        public List<string> Medicines
        {
            get => _medicines;
            set
            {
                _medicines = value;
                OnPropertyChanged();
            }
        }

        private string _description;  //лечение
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private Doctor _doctor;
        public Doctor Doctor
        {
            get => _doctor;
            set
            {
                _doctor = value;
                OnPropertyChanged();
            }
        }
    }
}
