using System;
using Office.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Office.Utility;
using Office.Services;
using Office.Views;

namespace Office
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; set; } = new NavigationService();
        public static ProjectDataService ProjectDataService { get; set; } = new ProjectDataService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.ProjectListView, typeof(ProjectListView));
            NavigationService.Configure(ViewNames.ProjectDetailView, typeof(ProjectDetailView));

            MainPage = new NavigationPage(new ProjectListView()); //new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
