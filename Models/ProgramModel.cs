using System;

namespace Ipme.Hometraining.Models
{
    public class ProgramModel
    {
        private Guid _id;
        string _name;
        DateTime _created;
        Difficulty _difficulty;
        Guid _userId;  // créateur         

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
