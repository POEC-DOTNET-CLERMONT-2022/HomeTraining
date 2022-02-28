using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Ipme.Hometraining.Models
{
    public class ProgramModel : BindableBase
    {
        private Guid Id { get; set; }
        public string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public DateTime _created;
        public DateTime Created
        {
            get => _created;
            set => SetProperty(ref _created, value);
        }
        public Difficulty _difficulty;
        public Difficulty Difficulty
        {
            get => _difficulty;
            set => SetProperty(ref _difficulty, value);
        }
        public Guid UserId { get; set; }
        public ObservableCollection<ProgramExerciceModel> ExerciceList {  get; set; }

        public UserModel _user;
        public UserModel User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public ProgramModel(Guid id, string name, Difficulty difficulty, Guid userId)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (_name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));
            Id = id;
            _name = name;
            _created = DateTime.Today;
            _difficulty = difficulty;
            UserId = userId;
        }
    }

}
