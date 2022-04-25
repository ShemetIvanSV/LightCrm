using LightCrm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.Models
{
    public class ModelOrder : BaseViewModel
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        private string _patientName;
        public string PatientName 
        {
            get => _patientName;
            set
            {
                _patientName = value;
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

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        private string _doctorName;
        public string DoctorName
        {
            get => _doctorName;
            set
            {
                _doctorName = value;
                OnPropertyChanged();
            }
        }

        private string _paid;
        public string Paid 
        {
            get => _paid;
            set
            {
                _paid = value;
                OnPropertyChanged();
            }
        }

        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        private int _price;
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
    }
}
