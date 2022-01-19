using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {
        
        [ForeignKey("ExerciceId")]
        public ExerciceEntity Exercice { get; set; }

        [ForeignKey("ProgramId")]
        public ProgramEntity Program { get; set; }
        public int Repetitions { get; set; }
        public int Position { get; set; }

        public ProgramExerciceEntity(ExerciceEntity exercice, ProgramEntity program, int position, int repetitions)
        {
            Program = Program;
            Exercice = exercice;
            Repetitions = repetitions;
            Position = position;
            
        }

    }

}
