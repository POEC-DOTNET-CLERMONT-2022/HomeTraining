using Ipme.Hometraining.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipme.Hometraining.Entities
{
    [Table("Exercice")]
    public class ExerciceEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MuscleArea MuscleArea { get; set; }
        public string VideoName { get; set; }


        [ForeignKey("User")]    // Syntaxe OK ?
        public Guid UserId { get; set; }    

       // Tu as peut être déjà trouvé depuis ta question, mais au cas où : [ForeignKey(nom)]
       //  Et du coup la méthode correspondante dans le modelbuilder : HasForeignKey(item => item.MyForeignKey)


        public ExerciceEntity(Guid id, string name, string description, MuscleArea muscleArea, string videoName)
        {
            Id = id;
            Name = name;
            Description = description;
            MuscleArea = muscleArea;
            VideoName = videoName;
            UserId = UserId;
                        
        }


    }
}
