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
    public class ProjectsPage : ContentPage
    {
        public ProjectsPage()
        {
            ProjectsViewModel projectsVM = new ProjectsViewModel();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            foreach (Project project in projectsVM.Projects)
            {
                layout.Children.Add(new Label
                {
                    Text = project.title
                });

                layout.Children.Add(new Label
                {
                    Text = project.description
                });

                layout.Children.Add(new Label
                {
                    Text = $"Type: {project.type}"
                });
            }

            Content = new ScrollView
            {
                Content = layout
            };
        }
    }
}
