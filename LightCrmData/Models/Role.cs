using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightCrmData.Models
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название роли
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Пользователи за которыми закреплена данная роль
        /// </summary>
        public List<User> Users { get; set; }
    }
}
