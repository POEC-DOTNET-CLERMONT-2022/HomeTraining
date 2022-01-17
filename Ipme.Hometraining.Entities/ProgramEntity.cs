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
        public DateTime CreatedAt { get; set; }       
        public Difficulty Difficulty { get; set; }
        public Guid UserId { get; set; }
        private readonly List<ExerciceEntity> _exercices;

        public ProgramEntity(Guid id, string name, Difficulty difficulty, Guid userId)
        {
            Id = id;
            Name = name;
            CreatedAt = DateTime.Now;
            Difficulty = difficulty;
            UserId = userId;
            _exercices = new List<ExerciceEntity>();
        }

        public IEnumerable<ExerciceEntity> Exercices
        {
            get { return _exercices.AsReadOnly(); }
        }

    }
}
