using System;
using AutoFixture;
using Ipme.Hometraining.Models;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }
    }

}
