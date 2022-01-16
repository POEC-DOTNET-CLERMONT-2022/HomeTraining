using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ex = ExerciceApiRest.GetExercicesAsync("https://localhost:7266/api/Exercices");
            List<ExerciceDto> exDto = ex.Result;
            foreach(var exx in exDto)
            {
                ListExercice.Items.Add(exx);
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExerciceDto ex = new ExerciceDto() { 
                Name = "Squates sautés",
                Description = "",
                MuscleArea = MuscleArea.Jambes,
                VideoName = "" };
            ExerciceApiRest.PostExerciceAsync("https://localhost:7266/api/Exercices",ex);
        }
    }
}
