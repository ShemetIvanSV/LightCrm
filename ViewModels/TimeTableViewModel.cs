using LightCrm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.ViewModels
{
    class TimeTableViewModel : BaseViewModel, IPageViewModel
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

        public ObservableCollection<TimeTableControlModel> TimeTableCollection { get; set; }
        private int Day;
        public TimeTableViewModel()
        {
            TimeTableControlModel ui = new TimeTableControlModel();

            TimeTableCollection = new ObservableCollection<TimeTableControlModel>
            {
                new TimeTableControlModel 
                                          
                { 
                    Id = 1, 
                    Surname = ui.Surname, 
                    Name = ui.Name, 
                    Patronymic = ui.Patronymic,
                    Role = ui.Role,
                    DayOfWeek = ui.DayOfWeek,
                    StartTime = ui.StartTime,
                    EndTime = ui.EndTime,
                    
                }
            };
            Name = "График работы";
        }
    }
}
