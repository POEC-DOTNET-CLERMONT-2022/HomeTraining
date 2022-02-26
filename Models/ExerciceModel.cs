
using Prism.Mvvm;
using System;


namespace Ipme.Hometraining.Models
{
    /*
     * Classe représentant un exercice concret
     */

    public class ExerciceModel : BindableBase
    {
        public Guid Id { get; set; }
        
        public Guid UserId { get; set; }  // créateur de l'exercice

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        public MuscleArea _muscleArea;
        public MuscleArea MuscleArea
        {
            get => _muscleArea;
            set => SetProperty(ref _muscleArea, value);
        }
        public string _videoName;

        public string VideoName
        {
            get => _videoName;
            set => SetProperty(ref _videoName, value);
        }
        public ExerciceModel(Guid id, string name, string description, MuscleArea muscleArea, string videoName, Guid userId)
        {           
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));
            Id = id;
            Name = name;
            Description = description;
            MuscleArea = muscleArea;
            VideoName = videoName;
            UserId = userId;
        }
    }
}

