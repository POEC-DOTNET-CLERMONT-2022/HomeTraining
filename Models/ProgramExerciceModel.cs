using Prism.Mvvm;
using System;


namespace Ipme.Hometraining.Models
{

    public class ProgramExerciceModel : BindableBase
    {

        // Inutile ??? 
        public Guid Id { get; private set; }

        private Guid ProgramId { get; set; }
        private Guid ExerciceId { get; set; }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value);
        }
        private int _repetitions;
        public int Repetitions
        {
            get => _repetitions;
            set => SetProperty(ref _repetitions, value);
        }

        private ExerciceModel _exercice;
        public ExerciceModel Exercice
        {
            get => _exercice;
            set => SetProperty(ref _exercice, value);
        }

        // public ProgramExerciceModel(ExerciceModel user) => this.user = user;


        public ProgramExerciceModel(Guid peId, Guid programId, ExerciceModel exercice, int position, int repetitions)
        {
            Id = peId;    
            ProgramId = programId;
            Exercice = exercice;
            Position = position;
            Repetitions = repetitions;

        }

    }

}
