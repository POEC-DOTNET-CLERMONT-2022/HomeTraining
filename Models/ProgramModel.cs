using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Ipme.Hometraining.Models
{
    public class ProgramModel : ObservableObject
    {
        private Guid _id;
        public string _name;
        public DateTime _created;
        public Difficulty _difficulty;
        public Guid _userId;
        private ObservableCollection<ProgramExerciceModel> _exerciceList;


        // UserId ou UserModel ???
        public UserModel _user;


        public UserModel User
        {
            get { return _user; }
            private set { _user = value; }
        }

        public ObservableCollection<ProgramExerciceModel> ExerciceList
        {
            get { return _exerciceList; }
            set
            {
                if (_exerciceList != value)
                {
                    _exerciceList = value;
                    OnNotifyPropertyChanged();
                }
            }
        }

        public ProgramModel(Guid id, string name, Difficulty difficulty, Guid userId)
        {
            // vérifier champs obligatoires non vides

            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));

            _id = id;
            _name = name;
            _created = DateTime.Today;
            _difficulty = difficulty;
            _userId = userId;
        }
    }

}
