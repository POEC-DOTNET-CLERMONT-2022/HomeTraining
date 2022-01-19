using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClient.EventHandlers
{
    public class ExercicesListHandler : ObservableObject
    {
        //ListUSers
        private ObservableCollection<ExerciceModel> _exercices;

        public ObservableCollection<ExerciceModel> Exercices
        {
            get { return _exercices; }
            set
            {
                if (_exercices != value)
                {
                    _exercices = value;
                    OnNotifyPropertyChanged();
                }
            }
        }


    }
}
