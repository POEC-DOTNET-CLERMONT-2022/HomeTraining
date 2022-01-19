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

        public ProgramExerciceEntity(Guid exerciceID, Guid programID, int position, int repetitions)
        {
            ProgramID = programID;
            ExerciceID = exerciceID;
            Position = position;
            Repetitions = repetitions;
        }

    }

}
