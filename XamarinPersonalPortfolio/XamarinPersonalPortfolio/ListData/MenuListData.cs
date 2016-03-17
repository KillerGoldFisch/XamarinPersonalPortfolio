using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPersonalPortfolio.Models;
using XamarinPersonalPortfolio.Pages;

namespace XamarinPersonalPortfolio.ListData
{
    class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "About",
                TargetType = typeof(AboutPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Skills",
                TargetType = typeof(SkillsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Experience",
                TargetType = typeof(ExperiencePage)
            });

            this.Add(new MenuItem()
            {
                Title = "Projects",
                TargetType = typeof(ProjectsPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Contact",
                TargetType = typeof(ContactPage)
            });
        }
    }
}
