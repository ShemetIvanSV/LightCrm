using System;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Timetables
    {
        public int Id { get; set; }

        [Required]
        [Range(1,7)]
        public int DayOfWeek { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Required]
        public bool DayOff { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
