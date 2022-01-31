using Ipme.Hometraining.Entities;
using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.Persistance
{
    public interface IProgramExerciceRepository
    {
        IEnumerable<ProgramExerciceEntity> GetAllProgramExercices();

        ProgramExerciceEntity GetSingleProgramExercice(Guid id);

        void AddProgramExercice(ProgramExerciceEntity prgExEntity);

        ProgramExerciceEntity RemoveProgramExercice(Guid id);

        ProgramExerciceEntity UpdateProgramExercice(ProgramExerciceEntity prgExEntity);

    }


}
