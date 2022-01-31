using AutoMapper;
using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Models;
using Ipme.Hometraining.ModelView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Windows;
using System.Windows.Data;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private readonly IMapper _mapper = ((App)Application.Current).Mapper;

        readonly ObservableCollection<ProgramModel> _programs;
        public ObservableCollection<ExerciceModel> Exercices { get;  set; }
        readonly ObservableCollection<ProgramExerciceModel> _programsExercices;

        private readonly IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager= ((App)Application.Current).ExerciceDataManager;

        public Home()
        {
            InitializeComponent();            
            DataContext = this;
            brrr();
            //MuscleAreas = Enum.GetValues(typeof(MuscleArea));

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadExercicesAsync();
        }

        public async void LoadExercicesAsync()
        {
            /*await Policy.Execute(async () =>
            {*/
            var exercicesModel = ((ExerciceDataManager)ExerciceDataManager).GetExercicesFixture(MuscleArea.Abdos);
            Exercices = new ObservableCollection<ExerciceModel>((IEnumerable<ExerciceModel>)exercicesModel);     

            //});

        }

        private void brrr()
        {
            var exercicesModel = ((ExerciceDataManager)ExerciceDataManager).GetExercicesFixture(MuscleArea.Abdos);            
            Exercices = new ObservableCollection<ExerciceModel>(exercicesModel);
        }
    }
}
