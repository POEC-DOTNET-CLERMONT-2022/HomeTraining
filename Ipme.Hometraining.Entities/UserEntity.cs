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


        // ??? Id est utilisé en tant que clé étrangère dans Exercice et Program 
      //   [ForeignKey("Id")] //Nom de la propriété de la clé étrangère 


        public UserEntity()
        { 
        }

        public UserEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
