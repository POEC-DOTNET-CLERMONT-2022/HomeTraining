using AutoMapper;
using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using Ipme.Hometraining.ModelView;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFClient
{

    public partial class Home : Window
    {
        private readonly IMapper _mapper = ((App)Application.Current).Mapper;

        //readonly ObservableCollection<ProgramModel> _programs;
        public ObservableCollection<ExerciceModel> Exercices { get;  set; }
        //readonly ObservableCollection<ProgramExerciceModel> _programsExercices;

        public UserModel User { get; private set; }

        //TODO corriger la connexion en dur, page de connexion
        Guid userGuid = new Guid("DA286A18-43C9-51F1-1EBA-A76D2AC0B1DC");
        private readonly IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager= ((App)Application.Current).ExerciceDataManager;
        private readonly IDataManager<UserModel, UserDto> UserDataManager = ((App)Application.Current).UserDataManager;
        
        public Home()
        {
            InitializeComponent();  

        }
      


    }
}
