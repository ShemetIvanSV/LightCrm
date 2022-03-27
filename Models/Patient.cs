using System;
using LightCrm.ViewModels;

namespace LightCrm.Models
{
    public class Patient : BaseViewModel
    {
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

        private string _patientSurname;
        public string PatientSurname
        {
            get => _patientSurname;
            set
            {
                _patientSurname = value;
                OnPropertyChanged();
            }
        }

        private DateTime _date = DateTime.Today;
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        private string _patientEmail;
        public string PatientEmail
        {
            get => _patientEmail;
            set
            {
                _patientEmail = value;
                OnPropertyChanged();
            }
        }

        private string _patientSex;
        public string PatientSex
        {
            get => _patientSex;
            set
            {
                _patientSex = value;
                OnPropertyChanged();
            }
        }

        private int _patientNumber;
        public int PatientNumber
        {
            get => _patientNumber;
            set
            {
                _patientNumber = value;
                OnPropertyChanged();
            }
        }
    }
}
