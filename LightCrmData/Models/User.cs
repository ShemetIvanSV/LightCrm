using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    /// <summary>
    /// Пользователь системы
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [Required]
        public string Patronymic { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        [Required]
        public Role Role { get; set; }
        
        /// <summary>
        /// Рабочее место
        /// </summary>
        [Required]
        public Department Department { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        public List<Timetables> Timetables { get; set; }
    }
}