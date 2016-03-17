using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPersonalPortfolio.Models;

namespace XamarinPersonalPortfolio.ViewModels
{
    public class ExperienceViewModel
    {
        public List<Experience> Experience { get; set; }

        public ExperienceViewModel()
        {
            Experience = new List<Experience>();

            Experience.Add(new Experience { title = "Microsoft Student Partner", description = "As a Microsoft Student Partner, I help students and faculty do cool things with technology while getting them excited about the opportunities they have with Microsoft. Throughout the year, I will be hosting workshops, working with tech evangelists, and contributing to the community of developers at the University of Washington." });
            Experience.Add(new Experience { title = "Xamarin Student Partner", description = "As a part of the Xamarin Student Partner program, I represent Xamarin to spread native C# mobile development at the University of Washington, while also working to become a Xamarin Certified Mobile Developer. Throughout the year, I will be developing solutions and hosting workshops that showcase the Xamarin Platform." });
        }
    }
}
