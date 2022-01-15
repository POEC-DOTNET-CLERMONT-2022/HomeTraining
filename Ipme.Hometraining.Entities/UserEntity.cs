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
        public string Name { get; set; }

        public UserEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
