using Ipme.Hometraining.Models;
using System.Collections.ObjectModel;

namespace Ipme.Hometraining.ModelView
{
    public class ProgramExerciceModelView : ObservableObject
    {
        public ProgramExerciceModel ProgramExercice { get; set; }


        public ProgramExerciceModelView(ProgramExerciceModel programExercice)
        {
            ProgramExercice = programExercice;
        }

        public int Position
        {
            get { return ProgramExercice.Position; }
            set
            {
                ProgramExercice.Position = value;
                OnNotifyPropertyChanged();
            }
        }
        public int Repetitions
        {
            get { return ProgramExercice.Repetitions; }
            set
            {
                ProgramExercice.Repetitions = value;
                OnNotifyPropertyChanged();
            }
        }


        public ExerciceModel Exercice
        {
            get { return ProgramExercice.Exercice; }
            set
            {
                ProgramExercice.Exercice = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}