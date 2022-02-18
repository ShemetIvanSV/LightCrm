using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    /// <summary>
    /// Рабочее место
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
