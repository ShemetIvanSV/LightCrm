using System;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public bool Paid { get; set; }

        [Required]
        public bool Done { get; set; }

        public string Recipe { get; set; }

        [Required]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
