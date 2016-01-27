using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class ProjectsViewModel
    {
        public List<Project> Projects { get; set; }

        public ProjectsViewModel()
        {
            Projects = new List<Project>();

            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });

            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
            Projects.Add(new Project { title = "", description = "", type = "" });
        }
    }
}
