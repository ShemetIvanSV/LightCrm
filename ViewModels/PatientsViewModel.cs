using LightCrm.Commands;
using LightCrm.Models;
using System;
using System.Collections.ObjectModel;

namespace LightCrm.ViewModels
{
    public class PatientsViewModel : BaseViewModel, IPageViewModel
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


        private Patient _selectedPatient;
        public Patient SelectedPatient 
        {
            get => _selectedPatient;

            set
            {
                _selectedPatient = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Patient> Patients { get; set; }

        private RelayCommand _addPatient;
        public RelayCommand AddPatient
        {
            get
            {
                return _addPatient ??
                    (_addPatient = new RelayCommand(obj =>
                    {
                        Patient patient = new Patient();
                        Patients.Insert(0, patient);
                        SelectedPatient = patient;
                    }, obj => Patients.Count > 0));
            }
        }

        private RelayCommand _savePatient;
        public RelayCommand SavePatient
        {
            get
            {
                return _savePatient ??
                    (_savePatient = new RelayCommand(obj =>
                    {
                        Patients[0] = SelectedPatient;
                    }));
            }
        }

        private RelayCommand _deletePatient;
        public RelayCommand DeletePatient
        {
            get
            {
                return _deletePatient ??
                    (_deletePatient = new RelayCommand(obj =>
                    {
                        Patients.Remove(SelectedPatient);
                    },
                    (obj) => Patients.Count > 0));
            }
        }

        public PatientsViewModel()
        {
            SelectedPatient = new Patient();
            Patients = new ObservableCollection<Patient>();
            Patients.Add(SelectedPatient);

            Name = "Запись пациентов";
        }
    }
}