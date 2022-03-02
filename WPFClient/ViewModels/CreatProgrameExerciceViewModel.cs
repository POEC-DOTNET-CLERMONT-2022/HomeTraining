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
    public class CreatProgrameExerciceViewModel : BindableBase
    {
        //Commands
        public DelegateCommand AddProgramExerciceCommand { get; private set; }
        public DelegateCommand RemoveProgramExerciceCommand { get; private set; }
        public DelegateCommand SaveProgramExerciceCommand { get; set; }

        //MyBindings properties here 
        public ObservableCollection<ExerciceModel> Exercices { get; private set; }
        public ExerciceModel CurrentExercice { get; set; }
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

        //Injection du container de service
        public CreatProgrameExerciceViewModel(IUnityContainer container)
        {
            Program = new ProgramModel(Guid.NewGuid(), "", Difficulty, container.Resolve<UserModel>().Id);
            Exercices = new ObservableCollection<ExerciceModel>(); ;

            AddProgramExerciceCommand = new DelegateCommand(AddProgramExercice, CanAddProgramExercice);
            RemoveProgramExerciceCommand = new DelegateCommand(RemoveProgramExercice, CanRemoveProgramExercice);
            SaveProgramExerciceCommand = new DelegateCommand(SaveProgram, CanSaveProgram).ObservesProperty(() => Program.Name);

            exerciceDataManager = container.Resolve<ExerciceDataManager>();
            programDataManager = container.Resolve<ProgramDataManager>();
            _ = LoadData();

        }

        //recupération asynchrone des data
        private async Task LoadData()
        {
            IEnumerable<ExerciceModel> exercices = await exerciceDataManager.GetAll();
            Exercices.AddRange(exercices);
        }

        void AddProgramExercice()
        {
            ProgramExerciceModel exercice = new ProgramExerciceModel(Guid.NewGuid(), Program.Id, CurrentExercice, Program.EexerciceList.Count + 1, 0);
            Program.EexerciceList.Add(exercice);
            RemoveProgramExerciceCommand.RaiseCanExecuteChanged();
        }

        bool CanAddProgramExercice()
        {
            return true;
        }

        void RemoveProgramExercice()
        {
            Program.EexerciceList.Remove(CurrentProgramExercice);
            RemoveProgramExerciceCommand.RaiseCanExecuteChanged();
        }

        bool CanRemoveProgramExercice()
        {
            if (Program != null && Program.EexerciceList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void SaveProgram()
        {
            Program.Difficulty = Difficulty;
            programDataManager.Add(Program);
            CurrentExercice = null;
            Program.EexerciceList.Clear();
            Program.Name = "";

        }
        bool CanSaveProgram()
        {
            if (Program != null && !String.IsNullOrEmpty(Program.Name))
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
