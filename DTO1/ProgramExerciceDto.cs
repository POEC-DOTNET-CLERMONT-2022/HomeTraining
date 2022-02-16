using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    public class ProgramExerciceDto
    {        
        public Guid Id { get; set; }

        public Guid ProgramId { get; set; }

        public Guid ExerciceId { get; set; }

        public int Position { get; set; }

        public int Repetitions { get; set; }

    }

}
