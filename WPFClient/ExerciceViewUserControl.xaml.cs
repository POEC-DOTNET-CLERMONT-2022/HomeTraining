using Ipme.Hometraining.WCF;
using System;
using System.Windows.Controls;

namespace Ipme.Hometraining.WPFClient
{
    /// <summary>
    /// Logique d'interaction pour ExerciceViewUserControl.xaml
    /// </summary>
    public partial class ExerciceViewUserControl : UserControl
    {
        public ExerciceService ExerciceService { get; }

        public ExerciceViewUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           
        }
    }
}
