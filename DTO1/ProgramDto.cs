using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    public class ProgramDto
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Created { get; set; }

        [DataMember]
        public Difficulty Difficulty { get; set; }

        [DataMember]
        public Guid UserId { get; set; }

       // à anlever du Dto
       // public List<ProgramExerciceDto> ExerciceList { get; set; }
       // public UserModel User { get; set; }

    }
}
