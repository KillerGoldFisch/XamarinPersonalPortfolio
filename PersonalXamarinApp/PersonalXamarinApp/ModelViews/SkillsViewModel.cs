using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class SkillsViewModel
    {
        public List<Skill> Skills { get; set; }

        public SkillsViewModel()
        {
            Skills = new List<Skill>();

            Skills.Add(new Skill { title = "", description = "" });
            Skills.Add(new Skill { title = "", description = "" });
            Skills.Add(new Skill { title = "", description = "" });
            Skills.Add(new Skill { title = "", description = "" });
            Skills.Add(new Skill { title = "", description = "" });
            Skills.Add(new Skill { title = "", description = "" });
        }
    }
}
