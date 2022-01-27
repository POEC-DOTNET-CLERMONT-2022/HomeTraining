using System;
using System.ComponentModel;

namespace Ipme.Hometraining.Models
{
    /*
     * Classe représentant un exercice concret
     */

    public class ExerciceModel
    {
        public Guid Id;
        public string Name { get; set; }
        public string Description { get; set; }
        public MuscleArea MuscleArea { get; set; }
        public string VideoName { get; set; }
        public Guid UserId { get; set; }  // créateur de l'exercice

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

