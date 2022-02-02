using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    public class ProgramExerciceDto
    {
        
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid ProgramId { get; set; }

        [DataMember]
        public Guid ExerciceId { get; set; }

        [DataMember]
        public int Position { get; set; }

        [DataMember]
        public int Repetitions { get; set; }


    }

}
