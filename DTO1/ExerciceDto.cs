using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    //TODO : à supprimer 
    [DataContract]
    public class ExerciceDto
    {
        //TODO : à supprimer 
        [DataMember]
        public Guid Id { get; set; }

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