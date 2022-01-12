using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Ipme.Hometraining.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Objet importé de PERSISTANCE afin de récupérer des USERS
        //public ExerciceServiceClient UserServiceClient { get; }

        public MainWindow()
        {
            //var exercices = GetExercicesFromCode();
            InitializeComponent();

         /*  ExerciceServiceClient = new ExerciceServiceClient();
            ExercicesZone.ItemsSource = ExerciceServiceClient.GetUExercices();

            /*foreach (var area in Enum.GetValues(typeof(MuscleArea)))
            {
                TabItem newTabItem = new TabItem
                {
                    Header = area.ToString(),

                };
                if (area.ToString() == MuscleArea.Abdos.ToString())
                {
                    ListBox lb = new ListBox();
                    //lb.AddHandler(new RoutedEvent);
                    lb.ItemsSource = exercices;
                    newTabItem.Content = lb;
                }

                TypeExerciceTab.Items.Add(newTabItem);
            }*/


        }


       /*nternal List<Exercice> GetExercicesFromCode()
        {
            var exercices = new List<Exercice>();
            var ex1 = new Exercice(MuscleArea.Abdos, "Le crunch au sol", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");
            var ex2 = new Exercice(MuscleArea.Abdos, "Le crunch combiné, ou le V - Up", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");
            var ex3 = new Exercice(MuscleArea.Abdos, "Le relevé de jambes au sol", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");
            var ex4 = new Exercice(MuscleArea.Abdos, "Rotations au sol pour les obliques", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");
            var ex5 = new Exercice(MuscleArea.Abdos, "Gainage frontal", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");
            var ex6 = new Exercice(MuscleArea.Abdos, "Les ciseaux", "Exercice basique pour des abdos au top", "Seoul-21985.mp4");

            exercices.Add(ex1);
            exercices.Add(ex2);
            exercices.Add(ex3);
            exercices.Add(ex4);
            exercices.Add(ex5);
            exercices.Add(ex6);
            return exercices; 
        }*/

    }
}
