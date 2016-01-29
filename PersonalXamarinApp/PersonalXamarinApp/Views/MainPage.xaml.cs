using PersonalXamarinApp.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalXamarinApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new PortfolioViewModel();
            Title = "Abhishek Joshi Portfolio";

            InitializeComponent();
        }
    }
}
