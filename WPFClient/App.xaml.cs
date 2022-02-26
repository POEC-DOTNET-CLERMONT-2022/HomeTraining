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

namespace WPFClient
{

    public partial class App : PrismApplication
    {
        private IMapper _mapper { get; }
        private const string SERVER_URL = "https://localhost:7266";
        private HttpClient _httpClient;       

        //OAuth0
        string Auth0Domain = "dev-2hpu-3au.eu.auth0.com";
        string Auth0ClientId = "b4JWfGG0VDABmp4R0bK2ShZtNCnOcTLE";
        UserModel CurrentUser = null;

        public App()
        {
            _httpClient = new HttpClient();
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            _mapper = new Mapper(configuration);
        }


        //Création de la fenetre main Shell
        protected override Window CreateShell()
        {
            return Container.Resolve<Home>();
        }

        //Enregistrement des Servivces
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
           
            containerRegistry.RegisterForNavigation<CreatProgrameExerciceView>();
            containerRegistry.RegisterForNavigation<UserAuthView>();

            containerRegistry.RegisterInstance<IDataManager<ExerciceModel, ExerciceDto>>(new ExerciceDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<IDataManager<UserModel, UserDto>>(new UserDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<IDataManager<ProgramModel, ProgramDto>>(new ProgramDataManager(_httpClient, _mapper, SERVER_URL));
            containerRegistry.RegisterInstance<IDataManager<ProgramExerciceModel, ProgramExerciceDto>>(new ProgramExerciceDataManager(_httpClient, _mapper, SERVER_URL));

        }

        //Gestionnaire de module
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
           
        }

      
    }
}
