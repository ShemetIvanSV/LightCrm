using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
