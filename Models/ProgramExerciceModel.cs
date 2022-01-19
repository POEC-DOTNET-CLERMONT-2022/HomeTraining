using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Models
{

    public class ProgramExerciceModel
    {
        private Guid ProgramID { get; set; }
        private Guid ExerciceID { get; set; }
        public int Position { get; set; }
        public int Repetitions { get; set; }

        public ExerciceModel Exercice { get; set; } 

        // ? ProgramModel 

        public ProgramExerciceModel(string name, Guid programID, Guid exerciceID, int position, int repetitions)
        {
            ExerciceID = exerciceID;
            ProgramID = programID;
            Repetitions = repetitions;
            Position = position;

        }

    }

}
