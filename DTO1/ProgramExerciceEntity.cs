using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {
        [Key]
        Guid ExerciceID { get; set; }
        Guid ProgramID { get; set; }
        int Repetitions { get; set; }
        int Position { get; set; }
        public string Name { get; }
        private readonly List<ExerciceEntity> _exercices;

        public ProgramExerciceEntity(string name,Guid exerciceID,Guid programID,int position,int repetitions)
        {
            ExerciceID = exerciceID;
            ProgramID = programID;
            Name = name;
            Position = position;
            Repetitions = repetitions;
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
