using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CrmServices.Dtos
{
    [DataContract]
    public class TimeTableDto
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
    }
}