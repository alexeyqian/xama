using System;
using System.Windows.Input;
using Office.Models;
using Office.Services;
using Office.Utility;
using Xamarin.Forms;

namespace Office.ViewModels
{
    public class ProjectDetailViewModel : BaseViewModel
    {
        private Project _selectedProject;
        private IProjectDataService _projectDataService;
        private INavigationService _navigationService;

        public Project SelectedProject
        {
            get => _selectedProject;
            set
            {
                _selectedProject = value;
                OnPropertyChanged(nameof(SelectedProject));
            }
        }

        public ICommand SaveCommand { get; }

        public ProjectDetailViewModel(IProjectDataService projectDataService, INavigationService navigationService)
        {
            _projectDataService = projectDataService;
            _navigationService = navigationService;

            SelectedProject = new Project();
            SaveCommand = new Command(OnSaveCommand);

        }

        private void OnSaveCommand()
        {
            if (SelectedProject.Id == Guid.Empty)
                _projectDataService.AddProject(SelectedProject);
            else
                _projectDataService.UpdateProject(SelectedProject);

            MessagingCenter.Send(this, MessageNames.ProjectChangedMessage, SelectedProject);
            _navigationService.GoBack();
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
                SelectedProject = new Project();
            else
                SelectedProject = parameter as Project;
        }

    }

}
