using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class ContactViewModel
    {
        public List<Contact> Contacts { get; set; }

        public ContactViewModel()
        {
            Contacts = new List<Contact>();

            Contacts.Add(new Contact { title = "Email", urlLong = "joshi.uw@gmail.com", urlShort = "joshi.uw@gmail.com" });
            Contacts.Add(new Contact { title = "Medium", urlLong = "https://medium.com/@abhishekj", urlShort = "medium.com/@abhishekj" });
            Contacts.Add(new Contact { title = "LinkedIn", urlLong = "https://linkedin.com/in/joshiabhishek1", urlShort = "linkedin.com/in/joshiabhishek1" });
            Contacts.Add(new Contact { title = "GitHub", urlLong = "https://github.com/JoshiAbhishek", urlShort = "github.com/JoshiAbhishek" });
            Contacts.Add(new Contact { title = "Twitter", urlLong = "https://twitter.com/_abhishekj", urlShort = "twitter.com/_abhishekj" });
        }
    }
}