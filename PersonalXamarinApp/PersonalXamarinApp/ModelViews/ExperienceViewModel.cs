using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class ExperienceViewModel
    {
        public List<Experience> Experience;

        public ExperienceViewModel()
        {
            Experience = new List<Experience>();

            Experience.Add(new Experience { title = "", description = "" });
            Experience.Add(new Experience { title = "", description = "" });
        }
    }
}
