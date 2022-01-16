using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Persistance;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Ipme.Hometraining.WCF
{  
    
    [ServiceContract]
    public interface IExerciceService
    {

        IExerciceManager ExerciceManager { get; }

        
        [OperationContract]
        IEnumerable<ExerciceDto> GetExercices();

        // TODO: ajoutez vos opérations de service ici

    }

}
