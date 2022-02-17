using Prism.Ioc;
using Prism.Modularity;

namespace WPFClient
{
    internal class HomeTrainingAppMoudule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CreatProgrameExerciceView>();
            containerRegistry.RegisterForNavigation<UserAuthView>();
        }

    }
}
