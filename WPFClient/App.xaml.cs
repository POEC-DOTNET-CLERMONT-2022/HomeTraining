using AutoMapper;
using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System.Net.Http;
using System.Windows;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Technique d'injection
        //injecter autre chose ici
        public IMapper Mapper { get; }

        private const string SERVER_URL = "https://localhost:7266";
        public HttpClient HttpClient { get; } = new HttpClient();

        public IDataManager<ExerciceModel, ExerciceDto> ExerciceDataManager { get; }
        public IDataManager<UserModel, UserDto> UserDataManager { get; }
        public IDataManager<ProgramModel, ProgramDto> ProgramDataManager { get; }
        public IDataManager<ProgramExerciceModel, ProgramExerciceDto> ProgramExerciceDataManager { get; }

        //public INavigator Navigator { get; } = new Navigator();

        public App()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            Mapper = new Mapper(configuration);
            ExerciceDataManager = new ExerciceDataManager(HttpClient, Mapper, SERVER_URL);
            UserDataManager = new UserDataManager(HttpClient, Mapper, SERVER_URL);
            ProgramDataManager = new ProgramDataManager(HttpClient, Mapper, SERVER_URL);
            ProgramExerciceDataManager = new ProgramExerciceDataManager(HttpClient, Mapper, SERVER_URL);

        }

        //private void App_OnStartup(object sender, StartupEventArgs e)
        //{
        //    Navigator.RegisterView(new LoginPage());
        //    Navigator.RegisterView(new HomePage());
        //}
    }
}
