using Ipme.Hometraining.Models;
using System.Windows;
using System.Windows.Controls;

namespace WPFClient.Views
{
    /// <summary>
    /// Logique d'interaction pour ExerciceUserControl.xaml
    /// </summary>
    public partial class ExerciceUserControl : UserControl
    {
        public ExerciceUserControl()
        {
            InitializeComponent();
        }

        //Ma proprieté, pour une dependency property pas besoins d'appeller on property changed
        //les proprietes doivent être publics
        public ExerciceModel ExerciceDetail
        {
            get
            {
                return (ExerciceModel)GetValue(exerciceDetailProperty);
            }
            set
            {
                SetValue(exerciceDetailProperty, value);
            }
        }
        //On enregiste la dependencypropert nomDeLaPropriete,TypeDeLaPRopriete,
        //et la classe de la propriété elle même qui se trouve plus haut
        public static readonly DependencyProperty exerciceDetailProperty =
        DependencyProperty.Register("ExerciceDetail", typeof(ExerciceModel),
        typeof(ExerciceUserControl));
    }
}
