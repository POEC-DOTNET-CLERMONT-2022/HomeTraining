using Ipme.Hometraining.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipme.Hometraining.Entities
{
    [Table("User")]
    public class UserEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public UserEntity(Guid id, string firstName, string lastName, string login, string password, bool isAdmin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
