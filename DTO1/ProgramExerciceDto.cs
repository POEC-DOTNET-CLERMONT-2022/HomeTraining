using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    [DataContract]
    public class ProgramExerciceDto
    {
        public Guid ProgramId { get; set; }

        public Guid UserId { get; set; }

        public int Position { get; set; }

        public int Repetitions { get; set; }

        public ExerciceDto Exercice { get; set; }

    }

}
