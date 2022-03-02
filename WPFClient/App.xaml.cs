using AutoMapper;
using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using Prism.Ioc;
using System.Net.Http;
using System.Windows;
using Prism.Modularity;
using WPFClient.Views;
using Prism.Unity;
using System;

namespace WPFClient
{

    public partial class App : PrismApplication
    {
        private IMapper _mapper { get; }
        private const string SERVER_URL = "https://localhost:7266";
        private HttpClient _httpClient;

        //OAuth        
        private UserModel CurrentUser;

        public App()
        {
            _httpClient = new HttpClient();
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            _mapper = new Mapper(configuration);
            CurrentUser = new UserModel(new Guid("da286a18-43c9-51f1-1eba-a76d2ac0b1dc"), "User", "User", "UserLogin", "SECRET", false);
        }


        //Création de la fenetre main Shell
        protected override Window CreateShell()
        {
            return Container.Resolve<Home>();
        }

        //Enregistrement des Servivces
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {         
            //views
            containerRegistry.RegisterForNavigation<CreatProgrameExerciceView>();
            containerRegistry.RegisterForNavigation<UserAuthView>();
            containerRegistry.RegisterForNavigation<ProgramesView>();

            //services
            containerRegistry.RegisterInstance<ExerciceDataManager>(new ExerciceDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<UserDataManager>(new UserDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<ProgramDataManager>(new ProgramDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<ProgramExerciceDataManager>(new ProgramExerciceDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<UserModel>(CurrentUser);
        }

        //Gestionnaire de module
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
           
        }

      
    }
}
