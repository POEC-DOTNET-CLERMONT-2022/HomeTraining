using Ipme.Hometraining.ApiData;
using Ipme.Hometraining.Models;
using Prism.Mvvm;
using System;
using System.ComponentModel;

namespace WPFClient.ViewModels
{
    public class CreatProgrameExerciceViewModel : BindableBase
    {
        public ICollectionView Exercices { get; private set; }
        //myBindings properties here 

        public CreatProgrameExerciceViewModel(/*ExerciceDataManager exerciceManager*/)
        {
            // Initialize the CollectionView for the underlying model
            // and track the current selection.
           
           /*IEnumerable<ExerciceModel>  exercices = (IEnumerable<ExerciceModel>)exerciceManager.GetAll();
            ObservableCollection<ExerciceModel> ex = new ObservableCollection<ExerciceModel>();
            ex.AddRange(exercices);
            Exercices = new ListCollectionView(ex);

            Exercices.CurrentChanged += SelectedItemChanged;*/
        }

        private void SelectedItemChanged(object sender, EventArgs e)
        {
            ExerciceModel current = Exercices.CurrentItem as ExerciceModel;
        }
    }
}
