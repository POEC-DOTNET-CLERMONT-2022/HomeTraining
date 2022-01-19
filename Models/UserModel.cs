using System;

namespace Ipme.Hometraining.Models
{
    internal class UserModel
    {
        private Guid _id;
        public string _firstName;
        public string _lastName;
        public string _login;
        public string _password;
        public bool _isAdmin;

        public UserModel(Guid id, string firstName, string lastName, string login, string password, bool isAdmin)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (firstName == null) throw new ArgumentOutOfRangeException(nameof(firstName));

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _login = login;
            _password = password;
            _isAdmin = isAdmin;
        }
        
    }
}
