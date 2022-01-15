using System;

namespace Ipme.Hometraining.Models
{
    internal class User
    {
        private Guid _id;
        string _name;

        public User(Guid id, string name)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));

            _id = id;
            _name = name;
        }


    }
}
