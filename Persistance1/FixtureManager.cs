using System;
using AutoFixture;
using Ipme.Hometraining.Models;
using System.Collections.Generic;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;

namespace Ipme.Hometraining.Persistance
{
    /*
     *Classe renvoyant des données sous forme de fixtures Exercice
     */
    public class FixtureManager
    {
        

        public void Generate()
        {
            //Guid id, string firstName, string lastName, string login, string password, bool isAdmin
            UserEntity user1 = new UserEntity(Guid.NewGuid(),"CHRV","Lioma","loma","123456lo",true);
            UserEntity user2 = new UserEntity(Guid.NewGuid(), "DC", "Paul", "paul", "123456pa", true);
            UserEntity user3 = new UserEntity(Guid.NewGuid(), "Bulk", "Stephane", "stef42", "123456st", true);
            var users = new List<UserEntity>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            //Guid id, string name, string description, MuscleArea muscleArea, string videoName,UserEntity user
            ExerciceEntity ex1 = new ExerciceEntity(Guid.NewGuid(),"Pompes",
                "Les pieds sont joints, et les mains écartées un peu plus loin que l'envergure des épaules." +
                " Le but de l'exercice est d'abaisser tout le corps en restant droit, grâce à l'unique travail des bras." +
                " Le corps descend jusqu'à ce que la poitrine frôle le sol.",MuscleArea.Bras,"",user1);
            ExerciceEntity ex2 = new ExerciceEntity(Guid.NewGuid(), "Crunch", "Le crunch est un exercice sollicitant le muscle droit" +
                " de l'abdomen et une alternative populaire au Sit Up. Il correspond à ce que l'on appelle « relevé de buste »."
                , MuscleArea.Abdos, "", user1);
            ExerciceEntity ex3 = new ExerciceEntity(Guid.NewGuid(), "Flexion", "La flexion sur jambes (angl. squat) est un mouvement d'accroupi qui constitue" +
                " un exercice poly-articulaire de force et de musculation ciblant les muscles de la cuisse (principalement quadriceps," +
                " adducteurs et ischio-jambiers) et les fessiers."
                , MuscleArea.Jambes, "", user1);
            ExerciceEntity ex4 = new ExerciceEntity(Guid.NewGuid(), "Chaise", "La technique de la chaise consiste à rester " +
                "immobile pendant un certain temps dans une position statique. Il permet de sculpter les jambiers, les muscles fessiers, les cuisses et bien d'autres groupes musculaires."
                , MuscleArea.Jambes, "", user1);
            ExerciceEntity ex5 = new ExerciceEntity(Guid.NewGuid(), "Gainage ", "En position de pompes avec le poids réparti sur les avant-bras," +
                " et les pieds, l'objectif est de tenir le plus longtemps possible. Dans cet exercice, il faut garder le dos droit et avoir les muscles" +
                " contractés pour avoir une meilleure stabilité."
                , MuscleArea.Dos, "", user1);
            ExerciceEntity ex6 = new ExerciceEntity(Guid.NewGuid(), "Traction ", "C'est un exercice qui consiste à soulever le poids du corps de manière à élever la poitrine jusqu'au niveau de la barre"
                , MuscleArea.Bras, "", user1);
            ExerciceEntity ex7 = new ExerciceEntity(Guid.NewGuid(), "Dips ", "Les dips sont un mouvement de musculation que l'on appelle : poly-articulaire, c'est-à-dire qu'il sollicite de nombreux groupes musculaires."
                , MuscleArea.Bras, "", user2);
            ExerciceEntity ex8 = new ExerciceEntity(Guid.NewGuid(), "V - UP", "Lors du V-Up, relevez les jambes et le buste simultanément."
                , MuscleArea.Abdos, "", user2);
            

            //Guid id, string name, Difficulty difficulty, UserEntity user
            ProgramEntity pg1 = new ProgramEntity(Guid.NewGuid(),"Le six pack",Difficulty.Moyen,user1);
            ProgramEntity pg2 = new ProgramEntity(Guid.NewGuid(), "Le panthéon", Difficulty.Difficile, user1);
            ProgramEntity pg3 = new ProgramEntity(Guid.NewGuid(), "Fast and Fit", Difficulty.Facile, user1);


            //ProgramEntity program, ExerciceEntity exercice, int position, int repetitions
            ProgramExerciceEntity pgrEx1 = new ProgramExerciceEntity(pg1,ex1,1,20);
            ProgramExerciceEntity pgrEx2 = new ProgramExerciceEntity(pg2, ex2, 2, 20);
            ProgramExerciceEntity pgrEx3 = new ProgramExerciceEntity(pg3, ex3, 3, 10);
            ProgramExerciceEntity pgrEx4 = new ProgramExerciceEntity(pg1, ex1, 4, 15);


        }
    }

}
