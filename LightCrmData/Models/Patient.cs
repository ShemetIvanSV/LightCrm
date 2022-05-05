using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrmData.Models
{
    /// <summary>
    /// Пациент в системе 
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Индетификатор Пациента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя Пациента
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия Пациента 
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество Пациента
        /// </summary>
        [Required]
        public string Patronymic { get; set; }

        /// <summary>
        /// День рождения Пациента
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Пол Пациента 
        /// </summary>
        [Required]
        public bool Gender { get; set; }

        /// <summary>
        /// Телеыонный номер Пациента 
        /// </summary>
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Почта Пациета
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Алергия/Болезнь Пациента 
        /// </summary>
        [Required]
        public string Allergies { get; set; }


    }
}
