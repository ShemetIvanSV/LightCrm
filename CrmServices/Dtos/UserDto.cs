using LightCrmData.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CrmServices.Dtos
{
    [DataContract]
    public class UserDto
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
        public string Username { get; set; }
        
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public Role Role { get; set; }

        [DataMember]
        public Department Department { get; set; }

        [DataMember]
        public List<Timetables> Timetables { get; set; }
    }
}