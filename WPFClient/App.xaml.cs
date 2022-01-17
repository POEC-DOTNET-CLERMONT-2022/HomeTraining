using AutoMapper;
using System.Windows;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Technique d'injection du Mapper
        //injecter autre chose ici
        public IMapper Mapper { get; }

        public App()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            Mapper = new Mapper(configuration);
        }
    }
}
