using System;
using System.ComponentModel;

namespace Ipme.Hometraining.Models
{
    /*
     * Classe représentant un exercice concret
     */

    public class ExerciceModel : ObservableObject
    {
        public Guid Id;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public MuscleArea MuscleArea { get; private set; }
        public string VideoName { get; private set; }


        // UserId ou UserModel ???
        public Guid UserId { get; private set; }  // créateur de l'exercice


        public ExerciceModel(Guid id, string name, string description, MuscleArea muscleArea, string videoName, Guid userId)
        {
            // vérifier champs obligatoires non vides

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

