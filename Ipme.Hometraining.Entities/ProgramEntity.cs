using Ipme.Hometraining.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipme.Hometraining.Entities
{
    [Table("Program")]
    public class ProgramEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }       
        public Difficulty Difficulty { get; set; }


        [ForeignKey("User")]    // Syntaxe OK ?
        public Guid UserId { get; set; }
              


    }
}
