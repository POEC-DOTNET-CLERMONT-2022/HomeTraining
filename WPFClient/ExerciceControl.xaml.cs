﻿using Ipme.Hometraining.Models;
using Ipme.Hometraining.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFClient
{
    /// <summary>
    /// Logique d'interaction pour ExerciceControl.xaml
    /// </summary>
    public partial class ExerciceControl : UserControl
    {
        public ExerciceModelView ex { get; set; }
        
        public ExerciceControl()
        {
            InitializeComponent();
            DataContext = this;
            ex = new ExerciceModelView(new ExerciceModel(Guid.NewGuid(), "Blabla", "Tralalla", MuscleArea.Dos, "Hehehe", Guid.NewGuid()));

    }


}
}