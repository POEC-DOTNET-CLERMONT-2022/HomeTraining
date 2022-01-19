using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.Models
{
    public class ProgramModel
    {
        private Guid _id;
        public string _name;
        public DateTime _created;
        public Difficulty _difficulty;
        public Guid _userId;  // créateur         

        public List<ProgramExerciceModel> ExerciceList { get; set; }

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


        // autre méthodes ?




    }

}
