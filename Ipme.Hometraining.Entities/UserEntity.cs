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
        public string LastNAme { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }

        public UserEntity(Guid id, string firstname, string lastname, string login, string password)
        {
            Id = id;
            FirstName = firstname;
            LastNAme = lastname;
            Login = login;
            Password = password;
            isAdmin = false;
        }


    }
}
