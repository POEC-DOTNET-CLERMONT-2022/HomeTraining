using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour AllExerciceView.xaml
    /// </summary>
    public partial class AllExerciceView : Page
    {
        private readonly IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager = ((App)Application.Current).ExerciceDataManager;

        public ObservableCollection<ExerciceModel> Exercices { get; set; }
        public ExerciceModel Currentexercice { get; set; } 

        public AllExerciceView()
        {
            InitializeComponent();
            DataContext = this;
            getAllExercices();

            Console.WriteLine("");

        }
       

        public async void getAllExercices()
        {
            //var exercices =  await ExerciceDataManager.GetAll();
            Exercices = new ObservableCollection<ExerciceModel>(getExFixtures());
            
        }
        
        public IEnumerable<ExerciceModel> getExFixtures()
        {
            ExerciceModel ex1 = new ExerciceModel(Guid.NewGuid(), "POMPES", "", MuscleArea.Pectoraux, "", Guid.NewGuid());
            ExerciceModel ex2 = new ExerciceModel(Guid.NewGuid(), "CRUNCH", "", MuscleArea.Abdos, "", Guid.NewGuid());
            ExerciceModel ex3 = new ExerciceModel(Guid.NewGuid(), "PLANCHE SUR LES AVANT-BRAS", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex4 = new ExerciceModel(Guid.NewGuid(), "PLANCHE BRAS TENDUS", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex5 = new ExerciceModel(Guid.NewGuid(), "BRIDGE", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex6 = new ExerciceModel(Guid.NewGuid(), "SQUATE", "", MuscleArea.Jambes, "", Guid.NewGuid());
            ExerciceModel ex7 = new ExerciceModel(Guid.NewGuid(), "FLEXION", "", MuscleArea.Jambes, "", Guid.NewGuid());
            ExerciceModel ex8 = new ExerciceModel(Guid.NewGuid(), "SUPERMAN", "", MuscleArea.Abdos, "", Guid.NewGuid());
            var exercices = new List<ExerciceModel>();
            exercices.Add(ex8);
            exercices.Add(ex2);
            exercices.Add(ex6);
            exercices.Add(ex7);
            exercices.Add(ex3);
            exercices.Add(ex4);
            exercices.Add(ex5);
            exercices.Add(ex1);
            return exercices;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("");
        }
    }
}
