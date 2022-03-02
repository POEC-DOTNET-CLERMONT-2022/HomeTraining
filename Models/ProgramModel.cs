using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace Ipme.Hometraining.Models
{
    public class ProgramModel : BindableBase
    {
        public Guid Id { get; private set; }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private DateTime _created;
        public DateTime Created
        {
            get => _created;
            set => SetProperty(ref _created, value);
        }
        private Difficulty _difficulty;
        public Difficulty Difficulty
        {
            get => _difficulty;
            set => SetProperty(ref _difficulty, value);
        }
        public Guid UserId { get; private set; }

        private ObservableCollection<ProgramExerciceModel> _exerciceList;
        public ObservableCollection<ProgramExerciceModel> EexerciceList
        {
            get => _exerciceList;
            set => SetProperty(ref _exerciceList, value);
        }


        public UserModel _user;
        public UserModel User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public ProgramModel(Guid id, string name, Difficulty difficulty, Guid userId)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));
            Id = id;
            Name = name;
            _created = DateTime.Today;
            _difficulty = difficulty;
            UserId = userId;
            _exerciceList = new ObservableCollection<ProgramExerciceModel>();
        }
    }

}
