using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Services
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public List<Roles> Role { get; set; }
    }
}
