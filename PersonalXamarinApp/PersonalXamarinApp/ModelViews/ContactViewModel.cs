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

            Contacts.Add(new Contact { title = "", urlLong = "", urlShort = "" });
            Contacts.Add(new Contact { title = "", urlLong = "", urlShort = "" });
            Contacts.Add(new Contact { title = "", urlLong = "", urlShort = "" });
            Contacts.Add(new Contact { title = "", urlLong = "", urlShort = "" });
            Contacts.Add(new Contact { title = "", urlLong = "", urlShort = "" });
        }
    }
}
