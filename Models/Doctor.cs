using System;
using LightCrm.ViewModels;

namespace LightCrm.Models

{
    public class Doctor : BaseViewModel
    {
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

        private string _doctorSurname;
        public string DoctorSurname
        {
            get => _doctorSurname;
            set
            {
                _doctorSurname = value;
                OnPropertyChanged();
            }
        }

        private string _doctorSpecialization;
        public string DoctorSpecialization
        {
            get => _doctorSpecialization;
            set
            {
                _doctorSpecialization = value;
                OnPropertyChanged();
            }
        }

        private string _doctorEmail;
        public string DoctorEmail
        {
            get => _doctorEmail;
            set
            {
                _doctorEmail = value;
                OnPropertyChanged();
            }
        }

        private int _doctorNumber;
        public int DoctorNumber
        {
            get => _doctorNumber;
            set
            {
                _doctorNumber = value;
                OnPropertyChanged();
            }
        }

        private string _doctorSex;
        public string DoctorSex
        {
            get => _doctorSex;
            set
            {
                _doctorSex = value;
                OnPropertyChanged();
            }
        }

    }
}
