using Ipme.Hometraining.Models;

namespace Ipme.Hometraining.ModelView
{
    public class UserModelView : ObservableObject
    {
        public UserModel User { get; set; }
        public UserModelView(UserModel user)
        {
            User = user;
        }

        public string FirstName
        {
            get { return User.FirstName; }
            set
            {
                User.FirstName = value;
                OnNotifyPropertyChanged();
            }
        }
        public string LastName
        {
            get { return User.LastName; }
            set
            {
                User.LastName = value;
                OnNotifyPropertyChanged();
            }
        }

        public string Login
        {
            get { return User.Login; }
            set
            {
                User.Login = value;
                OnNotifyPropertyChanged();
            }
        }

    }
}