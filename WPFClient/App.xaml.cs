using AutoMapper;
using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using Prism.Ioc;
using System.Net.Http;
using System.Windows;
using Prism.Unity;

namespace WPFClient
{

    public partial class App : PrismApplication
    {
        public IMapper Mapper { get; }

        private const string SERVER_URL = "https://localhost:7266";
        public HttpClient HttpClient { get; } = new HttpClient();
        public IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager { get; }
        public IDataManager<UserModel, UserDto> UserDataManager { get; }
        public IDataManager<ProgramModel, ProgramDto> ProgramDataManager { get; }
        public IDataManager<ProgramExerciceModel, ProgramExerciceDto> ProgramExerciceDataManager { get; }

        public App()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            Mapper = new Mapper(configuration);
            ExerciceDataManager = new ExerciceDataManager(HttpClient, Mapper, SERVER_URL);
            UserDataManager = new UserDataManager(HttpClient, Mapper, SERVER_URL);
            ProgramDataManager = new ProgramDataManager(HttpClient, Mapper, SERVER_URL);
            ProgramExerciceDataManager = new ProgramExerciceDataManager(HttpClient, Mapper, SERVER_URL);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Home>();
        }

        protected override Window CreateShell()
        {
            var w = Container.Resolve<Home>();
            return w;
        }
    }
}
