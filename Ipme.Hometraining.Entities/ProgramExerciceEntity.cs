using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {
        [Key]
        public Guid ProgramExerciceID { get; set; }

        public Guid ExerciceID;
        [ForeignKey("ProgramEntity")]
        public Guid programID;
        public int Repetitions { get; set; }
        public int Position { get; set; }

        public ProgramExerciceEntity(Guid exerciceID, Guid programID, int position, int repetitions)
        {
            ProgramExerciceID = Guid.NewGuid();
            programID = programID;
            ExerciceID = exerciceID;
            Repetitions = repetitions;
            Position = position;
            
        }

        [ForeignKey("ExerciceEntity")]
        public Guid ExerciceID {
            get
            {
                return ExerciceID;
            }
            set
            {

            }
        }
    }

}
