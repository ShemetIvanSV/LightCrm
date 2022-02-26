using LightCrm.TimeTablesServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.ViewModels
{
    internal class TimeTableViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        private userControlModel _currentUser;
        public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public TimeTableViewModel()
        {
            Name = "График работы";
        }
        private void GetTimeByUser()
        {
            using (var service = new TimeTablesServiceReference.TimeTablesServiceClient())
            {
                var times = service.GetTimeByUser(new UserDto());
            }
        }
    }
}
