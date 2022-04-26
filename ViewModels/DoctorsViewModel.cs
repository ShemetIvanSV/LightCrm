using LightCrm.Commands;
using LightCrm.Models;
using System;
using System.Collections.ObjectModel;

namespace LightCrm.ViewModels
{
    public class DoctorsViewModel : BaseViewModel, IPageViewModel
    {
        public string Name { get; set; }

        public Conclusion Conclusion { get; set; }

        public Patient CurrentPatient { get; set; }

        public DoctorsViewModel(User user)
        {
            Doctor = user;
            Name = "Окно врача";
            Conclusion = new Conclusion();
            Conclusion.Doctor = user;
        }

        public void Save()
        {
            
        }


    }
}
