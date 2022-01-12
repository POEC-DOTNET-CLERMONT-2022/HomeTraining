using Ipme.Hometraining.Persistance;
using System.Windows;
using WPFClient;

namespace Ipme.Hometraining.WPFClient
{
    /// <summary>
    /// Logique d'interaction pour UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {

        public IExerciceManager ExerciceManager { get; }

        public UserWindow()
        {
            //C'est ici qu'on change le manager BDD ou Fixtures pour le moment
            InitializeComponent();
            if (Application.Current is App app)
            {
                ExerciceManager = app.ExerciceManager;
            }
        }
    }
}
