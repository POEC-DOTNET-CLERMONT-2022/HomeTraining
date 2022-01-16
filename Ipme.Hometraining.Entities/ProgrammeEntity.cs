using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Ipme.Hometraining.Entities
{
    [Table("Programme")]
    public class ProgrammeEntity
    {
        [Key]
        Guid ID { get; set; }
        string Name { get; set; }
        DateTime CreatedAt { get; set; }

        private readonly List<ExerciceEntity> _exerci.ces;

        public ProgrammeEntity(string name)
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
