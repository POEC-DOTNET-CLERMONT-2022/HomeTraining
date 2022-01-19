using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    internal class ProgramExerciceDto
    {
        [DataMember]
        public Guid ProgramId { get; set; }

        [DataMember]
        public Guid UserId { get; set; }

        [DataMember]
        public int Position { get; set; }

        [DataMember]
        public int Repetitions { get; set; }



    }

}
