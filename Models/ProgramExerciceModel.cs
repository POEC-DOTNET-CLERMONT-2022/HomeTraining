using System;


namespace Ipme.Hometraining.Models
{

    public class ProgramExerciceModel : ObservableObject
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
