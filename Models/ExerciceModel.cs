using System;

namespace Ipme.Hometraining.Models
{
    /*
     * Classe représentant un exercice concret
     */
    public class ExerciceModel
    {
        private Guid _id;
        MuscleArea _muscleArea;
        string _name;
        string _description;
        string _videoName;


        public ExerciceModel(Guid id, MuscleArea muscleArea, string name, string description, string videoName)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            Id = id;
            _muscleArea = muscleArea;
            _name = name;
            _description = description;
            _videoName = videoName;
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

