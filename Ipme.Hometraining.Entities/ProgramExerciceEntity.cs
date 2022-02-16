using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {

        [Key]
        public Guid Id { get; set; }
        public int Position { get; set; }
        public int Repetitions { get; set; }

        public Guid ProgramId { get; set; }
        public virtual ProgramEntity Program { get; set; }

        public Guid ExerciceId { get; set; }
        public virtual ExerciceEntity Exercice { get; set; }


        public ProgramExerciceEntity()
        {
        }

        public ProgramExerciceEntity(ProgramEntity program, ExerciceEntity exercice, int position, int repetitions)
        {
            Id = Guid.NewGuid();
            Program = program;
            Exercice = exercice;
            Position = position;
            Repetitions = repetitions;    
        }

    }

}
