using LightCrmData.Models;
using System;
using System.Runtime.Serialization;

namespace CrmServices.Dtos
{
    [DataContract]
    public class TimeTableDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int DayOfWeek { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        public bool DayOff { get; set; }
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public Department Department { get; set; }
    }
}