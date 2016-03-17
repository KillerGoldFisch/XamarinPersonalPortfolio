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
    public class SkillsPage : ContentPage
    {
        public SkillsPage()
        {
            SkillsViewModel skillsVM = new SkillsViewModel();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            foreach (Skill skills in skillsVM.Skills)
            {
                layout.Children.Add(new Label
                {
                    Text = skills.title
                });

                layout.Children.Add(new Label
                {
                    Text = skills.description
                });
            }

            Content = new ScrollView
            {
                Content = layout
            };
        }
    }
}
