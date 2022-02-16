﻿using Ipme.Hometraining.Models;
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

<<<<<<< HEAD
=======
        public Guid UserId { get; set; }
>>>>>>> 44bb738bfa9a42abe1e25352b038c1a95bff9c7a
        public virtual UserEntity User { get; set; }    // ok pour Nico

        private ExerciceEntity()
        {
        }


        public ExerciceEntity(Guid id, string name, string description, MuscleArea muscleArea, string videoName, UserEntity user)
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
