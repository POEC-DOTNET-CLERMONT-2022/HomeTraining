using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Ipme.Hometraining.Models
{

    //TODO : à quoi sert ObservableObject ici ? 
    public class ProgramModel : ObservableObject
    {
        private Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public Difficulty Difficulty { get; set; }
        public Guid UserId { get; set; }
        public ObservableCollection<ProgramExerciceModel> ExerciceList {  get; set; }
        public UserModel User { get; set; }

        public ProgramModel(Guid id, string name, Difficulty difficulty, Guid userId)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));
            Id = id;
            Name = name;
            Created = DateTime.Today;
            Difficulty = difficulty;
            UserId = userId;
        }
    }

}
