using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class IntroductionViewModel
    {
        public Introduction Introduction { get; set; }

        public IntroductionViewModel()
        {
            Introduction = new Introduction { name = "Abhishek Joshi", description = "I love making applications and solving technical problems. As a sophomore at the University of Washington, I enjoy studying informatics and business while taking advantage of the incredible technology and entrepreneurship opportunities on campus." };
        }
    }
}