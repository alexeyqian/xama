using System;
using System.Collections.Generic;
using Office.Models;

namespace Office.Services
{
    public class ProjectDataService : IProjectDataService
    {
        public List<Project> GetAllProjects()
        {
            return ProjectRepository.Projects;
        }

        public void AddProject(Project project)
        {
            ProjectRepository.AddProject(project);
        }

        public void UpdateProject(Project project)
        {
            ProjectRepository.UpdateProject(project);
        }

    }
}
