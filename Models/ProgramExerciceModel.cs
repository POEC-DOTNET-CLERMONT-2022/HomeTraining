using System;


namespace Ipme.Hometraining.Models
{

    public class ProgramExerciceModel
    {

        // Inutile ??? 
        private Guid Id { get; set; }

        private Guid ProgramId { get; set; }
        private Guid ExerciceId { get; set; }
        public int Position { get; set; }
        public int Repetitions { get; set; }


        public ProgramExerciceModel(Guid peId, Guid programId, Guid exerciceId, int position, int repetitions)
        {
            Id = peId;    
            ProgramId = programId;
            ExerciceId = exerciceId;
            Position = position;
            Repetitions = repetitions;
        }

    }

}
