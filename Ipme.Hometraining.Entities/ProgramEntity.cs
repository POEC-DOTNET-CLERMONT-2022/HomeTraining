using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipme.Hometraining.Entities
{
    [Table("Program")]
    public class ProgramEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }       
        public Difficulty Difficulty { get; set; }

        
        public UserEntity User { get; set; }

        public List<ProgramExerciceEntity> ProgramExercices { get; set; }

        public ProgramEntity()
        {

        }

        public ProgramEntity(Guid id, string name, Difficulty difficulty, UserEntity user)
        {
            Id = id;
            Name = name;
            Created = DateTime.Now;
            Difficulty = difficulty;
            User = user;
        }


    }
}
