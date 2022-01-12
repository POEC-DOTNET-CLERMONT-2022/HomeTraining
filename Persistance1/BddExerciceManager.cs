using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.Persistance
{
    /*
     *Classe renvoyant des données à partir d'une base de données SQL ?
     */
    public class BddExerciceManager : IExerciceManager
    {
        public IEnumerable<ExerciceModel> GetAllExercices()
        {
            throw new NotImplementedException();
        }
    }
}
