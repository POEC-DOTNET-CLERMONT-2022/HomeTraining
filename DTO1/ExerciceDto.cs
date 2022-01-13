using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.DTO
{

    [DataContract]
    public class ExerciceDto
    {
        

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public MuscleArea MuscleArea { get; set; }

        [DataMember]
        public string VideoName { get; set; }


    }

}