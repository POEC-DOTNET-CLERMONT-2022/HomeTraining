using System;

namespace Ipme.Hometraining.Models
{
    /*
     * Classe représentant un exercice concret
     */

    public class ExerciceModel  // --> à renommer en Exercice 
    {
        private Guid _id;
        string _name;
        string _description;
        MuscleArea _muscleArea;
        string _videoName;
        Guid _userId;  // créateur de l'exercice


        public ExerciceModel(Guid id, string name, string description, MuscleArea muscleArea, string videoName, Guid userId)
        {
            // vérifier champs obligatoires non vides

            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));
            if (muscleArea == null) throw new ArgumentOutOfRangeException(nameof(muscleArea));  // test enum = 0 ?
            if (userId == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(userId));

            Id = id;
            _name = name;
            _description = description;
            _muscleArea = muscleArea;
            _videoName = videoName;
            _userId = userId;
        }


        /// <summary>
        /// Gets the ExerciceModel identifier
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}

