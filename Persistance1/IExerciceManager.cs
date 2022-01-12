using Ipme.Hometraining.Models;
using System.Collections.Generic;

namespace Ipme.Hometraining.Persistance
{
    public interface IExerciceManager
    {
        IEnumerable<ExerciceModel> GetAllExercices();

    }
}
