using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Data;
using Unity;

namespace WPFClient.ViewModels
{
    public class CreatProgrameExerciceViewModel : BindableBase
    {
        IUnityContainer Container;
        public ObservableCollection<ExerciceModel> Exercices { get; private set; }
        public ExerciceModel currentExercice { get; private set; }

        private ExerciceDataManager exerciceDataManager;
        private ProgramDataManager programDataManager;
        private ProgramExerciceDataManager programExerciceDataManager;
        private UserDataManager userDataManager;
        //myBindings properties here 

        public CreatProgrameExerciceViewModel(IUnityContainer container)
        {
            Exercices = new ObservableCollection<ExerciceModel>();
            Container = container;
            exerciceDataManager = container.Resolve<ExerciceDataManager>();
            programDataManager = container.Resolve<ProgramDataManager>();
            programExerciceDataManager = container.Resolve<ProgramExerciceDataManager>();
            userDataManager = container.Resolve<UserDataManager>();
            LoadData();
            
        }



        //private void SelectedItemChanged(object sender, EventArgs e)
        //{
        //    ExerciceModel current = Exercices.CurrentItem as ExerciceModel;
        //}

        private async Task LoadData()
        {
            IEnumerable<ExerciceModel> exercices = await exerciceDataManager.GetAll();

            Exercices.AddRange(exercices);
            
            //Exercices.CurrentChanged += SelectedItemChanged;
        }
    }
}
