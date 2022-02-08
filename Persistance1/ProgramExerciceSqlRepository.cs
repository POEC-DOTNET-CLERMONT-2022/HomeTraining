using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ipme.Hometraining.Persistance
{

    public class ProgramExerciceSqlRepository : IProgramExerciceRepository
    {
        //injection de dependance du DbContext
        private DbContext SqlContext { get; }

        public ProgramExerciceSqlRepository(DbContext sqlContext)
        {
            SqlContext = sqlContext;
        }

        public ProgramExerciceEntity GetSingleProgramExercice(Guid id)
        {
            return SqlContext.Set<ProgramExerciceEntity>().SingleOrDefault(prgEx => prgEx.Id == id);
        }

        public IEnumerable<ProgramExerciceEntity> GetAllProgramExercices()
        {
            return SqlContext.Set<ProgramExerciceEntity>().ToList();
        }

        public void AddProgramExercice(ProgramExerciceEntity prgExEntity)
        {
            SqlContext.Set<ProgramExerciceEntity>().Add(prgExEntity);
            SqlContext.SaveChanges();
        }

        public ProgramExerciceEntity RemoveProgramExercice(Guid id)
        {
            var prgExEntity = GetSingleProgramExercice(id);
            if (prgExEntity == null)
                return null;
            SqlContext.Set<ProgramExerciceEntity>().Remove(prgExEntity);
            SqlContext.SaveChanges();
            return prgExEntity;
        }

        public ProgramExerciceEntity UpdateProgramExercice(ProgramExerciceEntity prgExEntity)
        {
            var exo = GetSingleProgramExercice(prgExEntity.Id);
            if (exo == null)
                return null;
            SqlContext.Set<ProgramExerciceEntity>().Update(prgExEntity);
            SqlContext.SaveChanges();
            return prgExEntity;
        }

        IEnumerable<ProgramExerciceEntity> IProgramExerciceRepository.GetDetailProgram(Guid programId)
        {
            return SqlContext.Set<ProgramExerciceEntity>().Where(pe => pe.Program.Id == programId).ToList();
        }


    }

}



