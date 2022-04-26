using System;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    /// <summary>
    /// График работы 
    /// </summary>
    public class Timetables
    {
        /// <summary>
        /// Идентификатор графика
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// День недели
        /// </summary>
        [Required]
        [Range(1,7)]
        public int DayOfWeek { get; set; }

        /// <summary>
        /// Время начала рабочего дняя
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Время окончания рабочего дня
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Закончен ли рабочий день
        /// </summary>
        [Required]
        public bool DayOff { get; set; }

        /// <summary>
        /// Пользователь за которым закреплено данное расписание
        /// </summary>
        [Required]
        public User User { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        [Required]
        public Department Department { get; set; }
    }
}
