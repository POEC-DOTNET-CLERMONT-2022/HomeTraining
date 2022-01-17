﻿using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ipme.Hometraining.Persistance
{

    public class ExerciceSqlRepository : IExerciceRepository
    {
        //injection de dependance du DbContext
        private DbContext SqlContext { get; }


        public ExerciceSqlRepository(DbContext sqlContext)
        {
            SqlContext = sqlContext;
        }



        public ExerciceEntity GetSingleExercice(Guid id)
        {
            return SqlContext.Set<ExerciceEntity>().SingleOrDefault(exercice => exercice.Id == id);
        }

        public IEnumerable<ExerciceEntity> GetAllExercices()
        {
            return SqlContext.Set<ExerciceEntity>().ToList();
        }


        public void AddExercice(ExerciceEntity exerciceEntity)
        {
            SqlContext.Set<ExerciceEntity>().Add(exerciceEntity);
        }


        public ExerciceEntity RemoveExercice(Guid id)
        {
            var exerciceEntity = GetSingleExercice(id);
            if (exerciceEntity == null)
            {
                return null;
            }
              SqlContext.Set<ExerciceEntity>().Remove(exerciceEntity);
            return exerciceEntity;
        }
    }
}