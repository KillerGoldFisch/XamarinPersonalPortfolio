using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using XamarinPersonalPortfolio.ViewModels;

namespace XamarinPersonalPortfolio.Pages
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
            AboutViewModel aboutVM = new AboutViewModel();

            var layout = new StackLayout
            {
                Children = {
                    new Label
                    {
                        Text = aboutVM.About.name
                    },
                    new Label
                    {
                        Text = aboutVM.About.description
                    }
                }
            };

            Content = new ScrollView
            {
                Content = layout
            };
        }
    }
}
