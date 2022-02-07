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

        public UserModelView User { get; private set; }
        Guid userGuid = new Guid("DA286A18-43C9-51F1-1EBA-A76D2AC0B1DC");

        private readonly IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager= ((App)Application.Current).ExerciceDataManager;
        private readonly IDataManager<UserModel, UserDto> UserDataManager = ((App)Application.Current).UserDataManager;
        AllExerciceView exmc;
        public Home()
        {
            InitializeComponent();            
            DataContext = this;

            exmc = new AllExerciceView();

            //MuscleAreas = Enum.GetValues(typeof(MuscleArea));

        }
      
        public async void LoadApiData()
        {
            this.User = new UserModelView(UserDataManager.Get(userGuid).Result);

        }


    }
}
