using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {

        // Inutile ??? 
        [Key]
        public Guid Id { get; set; }


        public Guid ProgramId { get; set; }  

        [ForeignKey("ProgramId")]
        public virtual ProgramEntity Program { get; set; }


        public Guid ExerciceId { get; set; }   

        [ForeignKey("ExerciceId")]
        public virtual ExerciceEntity Exercice { get; set; }


        public int Position { get; set; }
        public int Repetitions { get; set; }

        public ProgramExerciceEntity()
        {

        }

        public ProgramExerciceEntity(ExerciceEntity exercice, ProgramEntity program, int position, int repetitions)
        {
            Id = Guid.NewGuid();
            Program = Program;
            Exercice = exercice;
            Repetitions = repetitions;
            Position = position;
            
        }

    }

}
