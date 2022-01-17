using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgrammeExerciceEntity
    {
        [Key]
        Guid ID { get; set; }
        int NombreRepetition { get; set; }
        int Position { get; set; }
        int NombrSeries { get; set; }
        public string Name { get; }
        public DateTime CreatedAt { get; }

        private readonly List<ExerciceEntity> _exercices;

        public ProgrammeExerciceEntity(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            _exercices = new List<ExerciceEntity>();
        }

        /// <summary>
        /// Gets the vehicle list from the garage
        /// </summary>
        public IEnumerable<ExerciceEntity> Exercices
        {
            get { return _exercices.AsReadOnly(); }
        }

    }
    
}
