using Ipme.Hometraining.Models;
using System;
using System.Runtime.Serialization;

namespace Ipme.Hometraining.Dto
{
    public class ExerciceDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public MuscleArea MuscleArea { get; set; }

        public string VideoName { get; set; }

        public Guid UserId { get; set; }

    }

}