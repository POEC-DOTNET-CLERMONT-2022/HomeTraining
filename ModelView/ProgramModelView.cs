using Ipme.Hometraining.Models;
using System.Collections.ObjectModel;

namespace Ipme.Hometraining.ModelView
{
    public class ProgramModelView : ObservableObject
    {
        public ProgramModel Program { get; set; }


        public ProgramModelView(ProgramModel program)
        {
            Program = program;
        }

        public string Name
        {
            get { return Program.Name; }
            set
            {
                Program.Name = value;
                OnNotifyPropertyChanged();
            }
        }
        public DateTime Created
        {
            get { return Program.Created; }
            set
            {
                Program.Created = value;
                OnNotifyPropertyChanged();
            }
        }


        public Difficulty Difficulty
        {
            get { return Program.Difficulty; }
            set
            {
                Program.Difficulty = value;
                OnNotifyPropertyChanged();
            }
        }

        public Guid UserId
        {
            get { return Program.UserId; }
            set
            {
                Program.UserId = value;
                OnNotifyPropertyChanged();
            }
        }

        public UserModel User
        {
            get { return Program.User; }
            set
            {
                Program.User = value;
                OnNotifyPropertyChanged();
            }
        }


        public ObservableCollection<ProgramExerciceModel> ExerciceList
        {
            get { return Program.ExerciceList; }
            set
            {
                if (Program.ExerciceList != value)
                {
                    Program.ExerciceList = value;
                    OnNotifyPropertyChanged();
                }
            }
        }

    }
}