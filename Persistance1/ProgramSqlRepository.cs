using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ipme.Hometraining.Persistance
{
    public class ProgramSqlRepository : IProgramRepository
    {
        //injection de dependance du DbContext
        private DbContext SqlContext { get; }

        public ProgramSqlRepository(DbContext sqlContext)
        {
            SqlContext = sqlContext;
        }

        public ProgramEntity GetSingleProgram(Guid id)
        {
            return SqlContext.Set<ProgramEntity>().SingleOrDefault(program => program.Id == id);
        }

        public IEnumerable<ProgramEntity> GetAllPrograms()
        {
            return SqlContext.Set<ProgramEntity>().Include(obj => obj.ProgramExercices).ToList();
        }

        public void AddProgram(ProgramEntity programEntity)
        {
            SqlContext.Set<ProgramEntity>().Add(programEntity);
            SqlContext.SaveChanges();
        }

        public ProgramEntity RemoveProgram(Guid id)
        {
            var programEntity = GetSingleProgram(id);
            if (programEntity == null)
                return null;
            SqlContext.Set<ProgramEntity>().Remove(programEntity);
            SqlContext.SaveChanges();
            return programEntity;
        }

        ProgramEntity IProgramRepository.UpdateProgram(ProgramEntity programEntity)
        {
            var program = GetSingleProgram(programEntity.Id);
            if (program == null)
                return null;
            SqlContext.Set<ProgramEntity>().Update(programEntity);
            SqlContext.SaveChanges();
            return programEntity;
        }

        IEnumerable<ProgramEntity> IProgramRepository.GetProgramsOfUser(Guid userId)
        {
            return SqlContext.Set<ProgramEntity>().Where(prg => prg.User.Id == userId).ToList();
        }


    }
}
