using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrmData.Models
{
    /// <summary>
    /// Услуги, которые предоставляются пациенту врачами
    /// </summary>
    public class DoctorService
    {
        /// <summary>
        /// Индетификатор услуги  
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя услуги 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Цена услуги
        /// </summary>
        [Required]
        public float Price { get; set; }


    }
}
