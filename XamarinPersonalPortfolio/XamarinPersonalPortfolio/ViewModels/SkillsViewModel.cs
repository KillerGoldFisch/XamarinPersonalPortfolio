using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPersonalPortfolio.Models;

namespace XamarinPersonalPortfolio.ViewModels
{
    public class SkillsViewModel
    {
        public List<Skill> Skills { get; set; }

        public SkillsViewModel()
        {
            Skills = new List<Skill>();

            Skills.Add(new Skill { title = "Web", description = "Utilized jQuery, ASP.NET MVC, Bootstrap, and AngularJS. Currently learning D3 and ReactJS." });
            Skills.Add(new Skill { title = "Mobile", description = "Familiar with Windows, Android, and Xamarin. Learning iOS and Swift development." });
            Skills.Add(new Skill { title = "Data", description = "Created relational database systems with SQL using SQL Server and MySQL." });
            Skills.Add(new Skill { title = "Cloud", description = "Understanding of cloud backend services including Parse, Firebase, and Azure." });
            Skills.Add(new Skill { title = "Code", description = "Background in object-oriented programming with data structures and algorithms." });
        }
    }
}
