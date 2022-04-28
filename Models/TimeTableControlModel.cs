using LightCrm.TimeTableServiceReference;
using LightCrm.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.Models
{
    class TimeTableControlModel : BaseViewModel
    {
        /// <summary>
        /// Идентификатор графика
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// День недели
        /// </summary>

        public int DayOfWeek { get; set; }

        /// <summary>
        /// Время начала рабочего дня
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Время окончания рабочего дня
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Закончен ли рабочий день
        /// </summary>

        public bool DayOff { get; set; }

        /// <summary>
        /// Пользователь за которым закреплено данное расписание
        /// </summary>

        public User User { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// Имя 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Логин
        /// </summary>

        public string Username { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>

        public string Password { get; set; }

        /// <summary>
        /// Роль
        /// </summary>

        public Role Role { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        public List<Timetables> Timetables { get; set; }

        public TimeTableControlModel()
        {
            TimeTableDto ui = new TimeTableDto();
            UserDto ui2 = new UserDto();

            Id = ui2.Id;
            Name = ui2.Name;
            Surname = ui2.Surname;
            Patronymic = ui2.Patronymic;
            Role = ui2.Role;
            DayOfWeek = ui.DayOfWeek;
            StartTime = ui.StartTime;
            EndTime = ui.EndTime;
            
        }
        //enum _DayOfWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        
    }
}