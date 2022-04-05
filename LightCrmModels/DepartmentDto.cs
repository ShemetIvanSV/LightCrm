using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LightCrmModels
{
    /// <summary>
    /// Рабочее место
    /// </summary>
    [DataContract]
    public class DepartmentDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}