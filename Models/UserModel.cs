using System;

namespace Ipme.Hometraining.Models
{
    public class UserModel
    {
        private Guid _id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string _password { get; set; }
        public bool _isAdmin;

        public UserModel(Guid id, string firstName, string lastName, string login, string password, bool isAdmin)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            if (firstName == null) throw new ArgumentOutOfRangeException(nameof(firstName));

            _id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            _password = password;
            _isAdmin = isAdmin;
        }
        
    }
}
