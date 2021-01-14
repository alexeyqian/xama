using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Office.Models;
using Office.Services;
using Office.Utility;
using Xamarin.Forms;

namespace Office.ViewModels
{
    public class ProjectListViewModel : BaseViewModel
    {
        private ObservableCollection<Project> _projects;

        private IProjectDataService _projectDataService;
        private INavigationService _navigationService;

        public ObservableCollection<Project> Projects
        {
            get => _projects;
            set
            {
                _projects = value;
                OnPropertyChanged("Projects");
            }
        }

        public ICommand LoadCommand { get; }
        public ICommand ProjectSelectedCommand { get; }
        public ICommand AddCommand { get; }

        public ProjectListViewModel(IProjectDataService projectDataService, INavigationService navigationService)
        {
            _projectDataService = projectDataService;
            _navigationService = navigationService;

            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            ProjectSelectedCommand = new Command<Project>(OnProjectSelectedCommand);

            Projects = new ObservableCollection<Project>();

            MessagingCenter.Subscribe<ProjectDetailViewModel, Project>(this, MessageNames.ProjectChangedMessage, OnProjectChanged);
        }

        private void OnLoadCommand()
        {
            Projects = new ObservableCollection<Project>(_projectDataService.GetAllProjects());
        }

        private void OnProjectSelectedCommand(Project project)
        {
            _navigationService.NavigateTo("ProjectDetailView", project);
        }

        private void OnAddCommand()
        {
            _navigationService.NavigateTo("ProjectDetailView");
        }

        private void OnProjectChanged(ProjectDetailViewModel sender, Project project)
        {
            Projects = new ObservableCollection<Project>(_projectDataService.GetAllProjects());
        }

        
    }
}
