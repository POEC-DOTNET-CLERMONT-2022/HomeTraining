using Ipme.Hometraining.DTO;
using Ipme.Hometraining.Persistance;
using System;
using System.Collections.Generic;

namespace Ipme.Hometraining.WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    //
    public class ExerciceService :IExerciceService
    {
        public IExerciceManager ExerciceManager => throw new NotImplementedException();


        public IEnumerable<ExerciceDto> GetExercices()
        {
            return new List<ExerciceDto>() { new ExerciceDto() { Name="Toto"}, new ExerciceDto() { Name = "Tata" } };
        }

    }
}
