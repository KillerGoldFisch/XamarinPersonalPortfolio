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
    public class ContactPage : ContentPage
    {
        public ContactPage()
        {
            ContactsViewModel contactsVM = new ContactsViewModel();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            foreach (Contact contacts in contactsVM.Contacts)
            {
                layout.Children.Add(new Label
                {
                    Text = contacts.title
                });

                layout.Children.Add(new Label
                {
                    Text = contacts.urlShort
                });
            }

            Content = new ScrollView
            {
                Content = layout
            };
        }
    }
}
