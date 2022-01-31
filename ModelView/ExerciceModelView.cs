using Ipme.Hometraining.Models;

namespace Ipme.Hometraining.ModelView
{
    public class ExerciceModelView : ObservableObject
    {
        public ExerciceModel Exercice { get; set; }
        public ExerciceModelView(ExerciceModel exercice)
        {
            Exercice = exercice;
        }

        public string Name
        {
            get { return Exercice.Name; }
            set
            {
                Exercice.Name = value;
                OnNotifyPropertyChanged();
            }
        }
        public string Description
        {
            get { return Exercice.Description; }
            set
            {
                Exercice.Description = value;
                OnNotifyPropertyChanged();
            }
        }

        public MuscleArea MuscleArea
        {
            get { return Exercice.MuscleArea; }
            set
            {
                Exercice.MuscleArea = value;
                OnNotifyPropertyChanged();
            }
        }

        public string VideoName
        {
            get { return Exercice.VideoName; }
            set
            {
                Exercice.VideoName = value;
                OnNotifyPropertyChanged();
            }
        }

        public Guid UserId
        {
            get { return Exercice.UserId; }
            set
            {
                Exercice.UserId = value;
                OnNotifyPropertyChanged();
            }
        }
                
    }
}