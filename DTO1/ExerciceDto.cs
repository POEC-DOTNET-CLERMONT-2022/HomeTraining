using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    public class ExerciceDto
    {        
        [DataMember]
        public Guid Id { get; set; }    // ajouter ID ???

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public MuscleArea MuscleArea { get; set; }

        [DataMember]
        public string VideoName { get; set; }

        [DataMember]
        public Guid UserId { get; set; }
                
    }

}