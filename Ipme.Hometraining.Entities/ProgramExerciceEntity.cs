using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Entities
{
    [Table("ProgramExercice")]
    public class ProgramExerciceEntity
    {
        [Key]
<<<<<<< HEAD

        public Guid ExerciceID;
        [ForeignKey("ProgramEntity")]
        public Guid programID;
=======
        public Guid Id { get; set; }
        [ForeignKey("ExerciceId")]
        public ExerciceEntity Exercice { get; set; }        
        [ForeignKey("ProgramId")]
        public ProgramEntity Program { get; set; }
>>>>>>> bdc0e16abd115c21a4cf91226b9e0d7e353cc7d1
        public int Repetitions { get; set; }
        public int Position { get; set; }

        public ProgramExerciceEntity()
        {
<<<<<<< HEAD
            programID = programID;
            ExerciceID = exerciceID;
=======

        }

        public ProgramExerciceEntity(ExerciceEntity exercice, ProgramEntity program, int position, int repetitions)
        {
            Id = Guid.NewGuid();
            Program = Program;
            Exercice = exercice;
>>>>>>> bdc0e16abd115c21a4cf91226b9e0d7e353cc7d1
            Repetitions = repetitions;
            Position = position;
            
        }

    }

}
