using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Roles
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public const byte Admin = 1;
        public const byte Operator = 2;
        public const byte Doctor = 3;
        public const byte Nurse = 4;

        public List<Services> Service { get; set; }
        //пример:
        public string a = "Первичный осмотр";
    }
}
