using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LightCrmModels
{
    /// <summary>
    /// Пользователь системы
    /// </summary>
    [DataContract]
    public class UserDto
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Имя 
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        [DataMember]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [DataMember]
        public string Patronymic { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        [DataMember]
        public RoleDto Role { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        [DataMember]
        public DepartmentDto Department { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        [DataMember]
        public List<TimetablesDto> Timetables { get; set; }
    }
}