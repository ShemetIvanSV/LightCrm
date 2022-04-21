using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrmData.Models
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Patronymic { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string  Email { get; set; }

        [Required]
        public string Specialization { get; set; }


    }
}
