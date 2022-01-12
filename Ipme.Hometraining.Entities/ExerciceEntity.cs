using Ipme.Hometraining.Models;
using System;


namespace Ipme.Hometraining.Entities
{
    
    public class ExerciceEntity
    {

   //     [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MuscleArea MuscleArea { get; set; }
        public string VideoName { get; set; }

        public ExerciceEntity(Guid id, string name, string description, MuscleArea muscleArea, string videoName)
        {
            Id = id;
            Name = name;
            Description = description;
            MuscleArea = muscleArea;
            VideoName = videoName;
        }


    }
}
