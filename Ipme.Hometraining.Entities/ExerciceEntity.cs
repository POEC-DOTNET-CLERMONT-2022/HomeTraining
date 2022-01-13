using Ipme.Hometraining.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipme.Hometraining.Entities
{
    [Table("Exercice")]
    public class ExerciceEntity
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MuscleArea MuscleArea { get; set; }
        public string VideoName { get; set; }

        public ExerciceEntity(Guid id, string name, string description, MuscleArea muscleArea, string videoName)
        {
            Id = id;
            Name = name;
            Description = description;
            MuscleArea = muscleArea;
            VideoName = videoName;
        }


    }
}
