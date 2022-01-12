using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.DTO
{

    [DataContract]
    public class ExerciceDto
    {
        [DataMember]
        public string Name { get; set; }

    }

}