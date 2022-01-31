using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    public class ProgramDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public Difficulty Difficulty { get; set; }

        public Guid UserId { get; set; }

       // à anlever du Dto
       // public List<ProgramExerciceDto> ExerciceList { get; set; }
       // public UserModel User { get; set; }

    }
}
