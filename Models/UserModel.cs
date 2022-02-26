using Prism.Mvvm;
using System;

namespace Ipme.Hometraining.Models
{
    public class UserModel : BindableBase
    {
        private Guid _id;

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

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        private string _login;
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password;

        
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }


        private bool _isAdmin;
        public bool IsAdmin
        {
            get => _isAdmin;
            set => SetProperty(ref _isAdmin, value);
        }
    }
}
