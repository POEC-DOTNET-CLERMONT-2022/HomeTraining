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
            return SqlContext.Set<ProgramEntity>().ToList();
        }

        public void AddProgram(ProgramEntity programEntity)
        {
            SqlContext.Set<ProgramEntity>().Add(programEntity);
        }

        public ProgramEntity RemoveProgram(Guid id)
        {
            var programEntity = GetSingleProgram(id);
            if (programEntity == null)
                return null;
            SqlContext.Set<ProgramEntity>().Remove(programEntity);
            return programEntity;
        }

        ProgramEntity IProgramRepository.UpdateProgram(ProgramEntity programEntity)
        {
            var program = GetSingleProgram(programEntity.Id);
            if (program == null)
                return null;
            SqlContext.Set<ProgramEntity>().Update(programEntity);
            return programEntity;

        }


    }
}
