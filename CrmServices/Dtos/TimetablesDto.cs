using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CrmServices.Dtos
{
    /// <summary>
    /// График работы 
    /// </summary>
    [DataContract]
    public class TimetablesDto
    {
        /// <summary>
        /// Идентификатор графика
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// День недели
        /// </summary>
        [DataMember]
        public int DayOfWeek { get; set; }

        /// <summary>
        /// Время начала рабочего дня
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Время окончания рабочего дня
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Закончен ли рабочий день
        /// </summary>
        [DataMember]
        public bool DayOff { get; set; }

        /// <summary>
        /// Пользователь за которым закреплено данное расписание
        /// </summary>
        [DataMember]
        public UserDto User { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        [DataMember]
        public DepartmentDto Department { get; set; }
    }
}