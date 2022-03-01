using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Unity;
using WPFClient.Views;

namespace WPFClient.ViewModels
{
    public class CreatProgrameExerciceViewModel : BindableBase
    {
        IUnityContainer Container;
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
        private ProgramExerciceDataManager programExerciceDataManager;
        private UserDataManager userDataManager;

        public CreatProgrameExerciceViewModel(IUnityContainer container)
        {
            Program = new ProgramModel(Guid.NewGuid(), "", Difficulty, new Guid("da286a18-43c9-51f1-1eba-a76d2ac0b1dc"));
            Exercices = new ObservableCollection<ExerciceModel>(); ;
            Container = container;
            AddProgramExerciceCommand = new DelegateCommand(AddProgramExercice, CanAddProgramExercice);
            RemoveProgramExerciceCommand = new DelegateCommand(RemoveProgramExercice, CanRemoveProgramExercice);
            SaveProgramExerciceCommand = new DelegateCommand(SaveProgram, CanSaveProgram).ObservesProperty(() => Program.Name);

            exerciceDataManager = container.Resolve<ExerciceDataManager>();
            programDataManager = container.Resolve<ProgramDataManager>();
            programExerciceDataManager = container.Resolve<ProgramExerciceDataManager>();
            userDataManager = container.Resolve<UserDataManager>();
            _ = LoadData();

        }

        private async Task LoadData()
        {
            IEnumerable<ExerciceModel> exercices = await exerciceDataManager.GetAll();
            Exercices.AddRange(exercices);
        }



        void AddProgramExercice()
        {
            ProgramExerciceModel exercice = new ProgramExerciceModel(Guid.NewGuid(), Program.Id, CurrentExercice, 0, 0);
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
        }
        bool CanRemoveProgramExercice()
        {
            if (Program!=null && Program.EexerciceList.Count > 0)
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
