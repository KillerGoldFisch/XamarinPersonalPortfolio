using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using XamarinPersonalPortfolio.Models;
using XamarinPersonalPortfolio.ViewModels;

namespace XamarinPersonalPortfolio.Pages
{
    public class ExperiencePage : ContentPage
    {
        public ExperiencePage()
        {
            ExperienceViewModel experienceVM = new ExperienceViewModel();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            foreach(Experience exp in experienceVM.Experience)
            {
                layout.Children.Add(new Label
                {
                    Text = exp.title
                });

                layout.Children.Add(new Label
                {
                    Text = exp.description
                });
            }

            Content = new ScrollView
            {
                Content = layout
            };
        }
    }
}