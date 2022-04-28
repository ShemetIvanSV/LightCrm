using LightCrm.Models;
using LightCrm.TimeTableServiceReference;
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

        public IEnumerable<TimeTableDto> TimeTables { get; set; }
        public IEnumerable<User> Users { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public UserDto _currentUser;
        public UserDto CurrentUser
        {
            get
            { 
                return _currentUser; 
            } 
            set
            {
                using (var service = new TimeTableServiceClient())
                {
                    TimeTables = service.GetTimeByUser(value);

                    //Id = value.Id,
                    //Name = value.Name,
                    //Surname = value.Surname
                    var monday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 1);
                    Monday = $"{monday.StartTime:t} - {monday.EndTime:t}";
                    var tuesday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 2);
                    Tuesday = $"{tuesday.StartTime:t} - {tuesday.EndTime:t}";
                    var wednesday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 3);
                    Wednesday = $"{wednesday.StartTime:t} - {wednesday.EndTime:t}";
                    var thursday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 4);
                    Thursday = $"{thursday.StartTime:t} - {thursday.EndTime:t}";
                    var friday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 5);
                    Friday = $"{friday.StartTime:t} - {friday.EndTime:t}";
                    var saturday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 6);
                    Saturday = $"{saturday.StartTime:t} - {saturday.EndTime:t}";
                    var sunday = TimeTables.FirstOrDefault(x => x.DayOfWeek == 7);
                    Sunday = $"{sunday.StartTime:t} - {sunday.EndTime:t}";
                };
                _currentUser = value;
                OnPropertyChanged();
            }
        }
        public TimeTableViewModel()
        {
            Name = "График работы";
        }
    }
}
