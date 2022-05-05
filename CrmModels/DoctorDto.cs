using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CrmModels
{
    [DataContract]
    public class DoctorDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Patronymic { get; set; }

        [DataMember]
        public DateTime Birthday { get; set; }

        [DataMember]
        public bool Sex { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Specialization { get; set; }
    }
}