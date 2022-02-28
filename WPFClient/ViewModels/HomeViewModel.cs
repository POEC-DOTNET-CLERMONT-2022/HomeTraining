using Ipme.Hometraining.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;

namespace WPFClient.ViewModels

{
    public class HomeViewModel : BindableBase
    {

        //readonly ObservableCollection<ProgramModel> _programs;
        public ObservableCollection<ExerciceModel> Exercices { get; set; }
        //readonly ObservableCollection<ProgramExerciceModel> _programsExercices;

        public UserModel CurrentUser { get; private set; }
        //data validations


        //TODO corriger la connexion en dur, page de connexion
        Guid userGuid = new Guid("DA286A18-43C9-51F1-1EBA-A76D2AC0B1DC");

        private readonly IRegionManager _regionManager;

        private string _title = "Prism Unity HomeTrainingApplication";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }

        public HomeViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
           
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }
    }
}
