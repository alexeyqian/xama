using System;
using System.Collections.Generic;
using Office.Utility;
using Xamarin.Forms;

namespace Office.Views
{
    public partial class ProjectDetailView : ContentPage
    {
        public ProjectDetailView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.ProjectDetailViewModel;
        }
    }
}
