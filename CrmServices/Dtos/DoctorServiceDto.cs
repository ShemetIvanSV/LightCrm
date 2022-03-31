using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CrmServices.Dtos
{
    [DataContract]
    public class DoctorServiceDto
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public float Price { get; set; }

    }
}