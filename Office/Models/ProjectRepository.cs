using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Models
{
    public static class ProjectRepository
    {
        static ProjectRepository()
        {
            if (Projects != null) return;
            
            Projects = new List<Project>
            {
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf1}"),
                    Name = "Project 1",
                    Description = "Project 1 Description",
                    IsStarted = false
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf2}"),
                    Name = "Project 2",
                    Description = "Project 2 Description",
                    IsStarted = false
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf3}"),
                    Name = "Project 3",
                    Description = "Project 3 Description",
                    IsStarted = false
                },
                new Project
                {
                    Id = Guid.Parse("{459d0316-355f-445c-8cc7-746dc9ceabf4}"),
                    Name = "Project 4",
                    Description = "Project 4 Description",
                    IsStarted = false
                },
            };
            
        }

        public static List<Project> Projects { get; set; }

        public static void AddProject(Project p)
        {
            p.Id = Guid.NewGuid();
            p.Name = "New Project";
            Projects.Add(p);
        }

        public static void UpdateProject(Project project)
        {
            var oldProject = Projects.Where(p => p.Id == project.Id).FirstOrDefault();
            oldProject.Name = project.Name;
            oldProject.Description = project.Description;
            oldProject.ImageUrl = project.ImageUrl;
            oldProject.IsStarted = project.IsStarted;
        }

    }
}
