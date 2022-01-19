using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ipme.Hometraining.Models
{

    public class ProgramExerciceModel
    {
        Guid ExerciceID { get; set; }
        Guid ProgramID { get; set; }
        int Repetitions { get; set; }
        int Position { get; set; }
        public string Name { get; }
        private readonly List<ExerciceModel> _exercices;

        public ProgramExerciceModel(string name, Guid exerciceID, Guid programID, int position, int repetitions)
        {
            ExerciceID = exerciceID;
            ProgramID = programID;
            Name = name;
            Position = position;
            Repetitions = repetitions;
            _exercices = new List<ExerciceModel>();
        }

        /// <summary>
        /// Gets the vehicle list from the garage
        /// </summary>
        public IEnumerable<ExerciceModel> Exercices
        {
            get { return _exercices.AsReadOnly(); }
        }

    }
    
}
