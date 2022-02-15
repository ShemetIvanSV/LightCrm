using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
