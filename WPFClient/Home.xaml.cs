using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Models;
using Ipme.Hometraining.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private readonly IMapper _mapper = ((App)Application.Current).Mapper;
        readonly ObservableCollection<ProgramModel> _programs;
        readonly ObservableCollection<ExerciceModel> _exercices;
        readonly ObservableCollection<ProgramExerciceModel> _programsExercices;

        readonly ExercicesListHandler _exercicesHandler = new ExercicesListHandler();


        public Home()
        {
            InitializeComponent();
            foreach (var zone in Enum.GetValues(typeof(MuscleArea)))
            {
                TabExercicesZone.Items.Add(new TabItem()
                {
                    Header = zone,
                    Content = new ListBox()
                    {

                    }
                });
            }
            //TODO corriger cette fonction fictive
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ex = ExerciceApiRest.GetExercicesAsync("https://localhost:7266/api/Exercices");
            List<ExerciceDto> exDto = ex.Result;
            foreach (var exx in exDto)
            {
                ListExercice.Items.Add(exx);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExerciceModel ex = new ExerciceModel(new Guid(), "Squates sautés", "", MuscleArea.Jambes, "", new Guid());
            ExerciceDto exDto = _mapper.Map<ExerciceDto>(ex);
            ExerciceApiRest.PostExerciceAsync("https://localhost:7266/api/Exercices", exDto);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Au revoir");
            MainWindow.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var exercicesModel = _mapper.Map<IEnumerable<ExerciceEntity>>(ExerciceApiRest.GetExercicesByZone("ALL"));
            //_exercicesHandler.Exercices = new ObservableCollection<ExerciceModel>(exercicesModel);
            SqlDbContext ctx = new SqlDbContext(new DbContextOptions<SqlDbContext>());
            ctx.Database.EnsureCreated();
            ctx.Exercices.AddRange(exercicesModel);
            ctx.SaveChanges();
        }
    }
}
