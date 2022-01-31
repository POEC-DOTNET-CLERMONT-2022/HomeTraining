using Ipme.Hometraining.Entities;
using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.Persistance
{
    public interface IProgramRepository
    {
        IEnumerable<ProgramEntity> GetAllPrograms();

        IEnumerable<ProgramEntity> GetProgramsOfUser(Guid userId);

        ProgramEntity GetSingleProgram(Guid id);

        void AddProgram(ProgramEntity programEntity);

        ProgramEntity RemoveProgram(Guid id);

        ProgramEntity UpdateProgram(ProgramEntity programEntity);

    }
}
