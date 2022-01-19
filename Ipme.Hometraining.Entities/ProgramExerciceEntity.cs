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
        public Guid ProgramExerciceID { get; set; }
        [ForeignKey("ExerciceEntity")]
        public Guid ExerciceID { get; set; }
        [ForeignKey("ProgramEntity")]
        public Guid ProgramID { get; set; }
        public int Repetitions { get; set; }
        public int Position { get; set; }

        public ProgramExerciceEntity(Guid exerciceID, Guid programID, int position, int repetitions)
        {
            ProgramExerciceID = Guid.NewGuid();
            ProgramID = programID;
            ExerciceID = exerciceID;
            Repetitions = repetitions;
            Position = position;
            
        }

    }

}
