using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private readonly IMapper _mapper = ((App)Application.Current).Mapper;
        readonly ObservableCollection<ProgramModel> _programs;
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
            ExerciceModel ex = new ExerciceModel(new Guid(),"Squates sautés","",MuscleArea.Jambes,"", new Guid());
            ExerciceDto exDto =  _mapper.Map<ExerciceDto>(ex);
            ExerciceApiRest.PostExerciceAsync("https://localhost:7266/api/Exercices",exDto);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Au revoir");
            MainWindow.Close();
        }
    }
}
