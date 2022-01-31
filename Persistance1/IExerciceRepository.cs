using Ipme.Hometraining.Entities;
using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.Persistance
{
    public interface IExerciceRepository
    {
        IEnumerable<ExerciceEntity> GetAllExercices();

        IEnumerable<ExerciceEntity> GetExercicesOfUser(Guid userId);

        ExerciceEntity GetSingleExercice(Guid id);

        void AddExercice(ExerciceEntity exerciceEntity);

        ExerciceEntity RemoveExercice(Guid id);

        ExerciceEntity UpdateExercice(ExerciceEntity exerciceEntity);

    }
}
