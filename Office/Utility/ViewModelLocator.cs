using System;
using Office.ViewModels;

namespace Office.Utility
{
    public static class ViewModelLocator
    {
        public static ProjectListViewModel ProjectListViewModel { get; set; } = new ProjectListViewModel(App.ProjectDataService, App.NavigationService);
        public static ProjectDetailViewModel ProjectDetailViewModel { get; set; } = new ProjectDetailViewModel(App.ProjectDataService, App.NavigationService);
    }
}
