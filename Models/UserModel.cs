using System;

namespace Ipme.Hometraining.Models
{
    internal class UserModel
    {
        private Guid _id;
        string _name;

        public UserModel(Guid id, string name)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (name == null) throw new ArgumentOutOfRangeException(nameof(name));

            _id = id;
            _name = name;
        }


    }
}
