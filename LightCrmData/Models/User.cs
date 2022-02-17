using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Patronymic { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Roles Role { get; set; }
        
        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Timetables> Timetables { get; set; }
    }
}
