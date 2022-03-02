using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Unity;

namespace WPFClient.ViewModels
{
    public class ProgramesViewModel : BindableBase
    {
        IUnityContainer Container;
        //Commands
      
        public DelegateCommand SaveProgramExerciceCommand { get; set; }

        //MyBindings properties here 
        public ObservableCollection<ProgramModel> UsersPrograms { get; private set; }
        
        public ProgramExerciceModel CurrentProgramExercice { get; set; }

        public ProgramModel Program { get; set; }

        public Difficulty _difficulties;
        public Difficulty Difficulty
        {
            get => _difficulties;
            set => SetProperty(ref _difficulties, value);
        }
        //DataManagers
        private ExerciceDataManager exerciceDataManager;
        private ProgramDataManager programDataManager;
        private ProgramExerciceDataManager programExerciceDataManager;
        private UserDataManager userDataManager;

        public ProgramesViewModel(IUnityContainer container)
        {
            UsersPrograms = new ObservableCollection<ProgramModel>(); ;
            Container = container;

            
            SaveProgramExerciceCommand = new DelegateCommand(SaveProgram, CanSaveProgram).ObservesProperty(() => Program.Name);

            exerciceDataManager = container.Resolve<ExerciceDataManager>();
            programDataManager = container.Resolve<ProgramDataManager>();
            programExerciceDataManager = container.Resolve<ProgramExerciceDataManager>();
            userDataManager = container.Resolve<UserDataManager>();
            _ = LoadData();

        }

        private async Task LoadData()
        {

            IEnumerable<ProgramModel> programmes = await programDataManager.GetAll();
            UsersPrograms.AddRange(programmes);
        }

         
        void SaveProgram()
        {
            programDataManager.Add(Program);
            Program = null;
        }
        bool CanSaveProgram()
        {
            if (Program!=null && !String.IsNullOrEmpty(Program.Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
