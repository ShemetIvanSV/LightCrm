using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Patronymic { get; set; }

        [Required]
        public DateTime DoB { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

       public List<Reservation> Reservations { get; set; }
    }
}
