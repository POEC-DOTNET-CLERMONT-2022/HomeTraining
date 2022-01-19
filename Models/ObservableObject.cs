using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ipme.Hometraining.Models
{
    public class ObservableObject : INotifyPropertyChanged
    {
        //Event
        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnNotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
