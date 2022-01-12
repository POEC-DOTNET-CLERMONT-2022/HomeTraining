using System;
using AutoFixture;
using Ipme.Hometraining.Models;
using System.Collections.Generic;
using Ipme.Hometraining.DTO;

namespace Ipme.Hometraining.Persistance
{
    /*
     *Classe renvoyant des données sous forme de fixtures Exercice
     */
    public class FixtureExerciceManager : IExerciceManager
    {
        private readonly Fixture _fixture = new Fixture();

        public IEnumerable<ExerciceModel> GetAllExercices()
        {
            var exos =   _fixture.Build<ExerciceModel>().CreateMany(10);
            return exos;
        }
    }

}
