using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public Guid Id { get; set; } 

        [DataMember]
        public string Name { get; set; }

    }
}
