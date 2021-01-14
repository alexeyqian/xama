using System;
using System.Collections.Generic;
using Office.Models;

namespace Office.Services
{
    public interface IProjectDataService
    {
        List<Project> GetAllProjects();
        void AddProject(Project project);
        void UpdateProject(Project project);
    }
}
