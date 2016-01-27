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
            Introduction = new Introduction { firstName = "", lastName = "", description = "" };
        }
    }
}