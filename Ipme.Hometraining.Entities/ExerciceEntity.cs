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
        public virtual UserEntity User { get; set; }    // ok pour Nico

        public Guid UserId { get; set; }

        private ExerciceEntity()
        {
        }


        public ExerciceEntity(Guid id, string name, string description, MuscleArea muscleArea, string videoName,UserEntity user)
        {
            if (id == Guid.Empty)
            { id = Guid.NewGuid(); };

            Id = id;
            Name = name;
            Description = description;
            MuscleArea = muscleArea;
            VideoName = videoName;
            User = user;
        }


    }
}
