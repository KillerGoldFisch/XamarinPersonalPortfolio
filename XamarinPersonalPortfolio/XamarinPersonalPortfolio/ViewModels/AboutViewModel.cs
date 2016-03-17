using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPersonalPortfolio.Models;

namespace XamarinPersonalPortfolio.ViewModels
{
    public class AboutViewModel
    {
        public About About { get; set; }

        public AboutViewModel()
        {
            About = new About { name = "Abhishek Joshi", description = "I love making applications and solving technical problems. As a sophomore at the University of Washington, I enjoy studying informatics and business while taking advantage of the incredible technology and entrepreneurship opportunities on campus." };
        }
    }
}
