﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CrmServices.Dtos
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    [DataContract]
    public class RoleDto
    {
        /// <summary>
        /// Идентификатор роли
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Название роли
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Пользователи за которыми закреплена данная роль
        /// </summary>
        [DataMember]
        public List<UserDto> Users { get; set; }
    }
}