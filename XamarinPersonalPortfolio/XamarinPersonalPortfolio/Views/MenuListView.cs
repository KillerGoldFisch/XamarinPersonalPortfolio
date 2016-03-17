using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPersonalPortfolio.ListData;
using XamarinPersonalPortfolio.Models;

namespace XamarinPersonalPortfolio.Views
{
    class MenuListView : ListView
    {
        public MenuListView()
        {
            List<Models.MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Title");

            ItemTemplate = cell;
        }
    }
}
