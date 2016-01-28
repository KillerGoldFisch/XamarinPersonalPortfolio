using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class PortfolioViewModel
    {

        public List<Contact> Contacts { get; set; }
        public List<Experience> Experience { get; set; }
        public Introduction Introduction { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }

        public PortfolioViewModel()
        {
            Contacts = new List<Contact>();

            Contacts.Add(new Contact { title = "Email", urlLong = "joshi.uw@gmail.com", urlShort = "joshi.uw@gmail.com" });
            Contacts.Add(new Contact { title = "Medium", urlLong = "https://medium.com/@abhishekj", urlShort = "medium.com/@abhishekj" });
            Contacts.Add(new Contact { title = "LinkedIn", urlLong = "https://linkedin.com/in/joshiabhishek1", urlShort = "linkedin.com/in/joshiabhishek1" });
            Contacts.Add(new Contact { title = "GitHub", urlLong = "https://github.com/JoshiAbhishek", urlShort = "github.com/JoshiAbhishek" });
            Contacts.Add(new Contact { title = "Twitter", urlLong = "https://twitter.com/_abhishekj", urlShort = "twitter.com/_abhishekj" });

            Experience = new List<Experience>();

            Experience.Add(new Experience { title = "Microsoft Student Partner", description = "As a Microsoft Student Partner, I help students and faculty do cool things with technology while getting them excited about the opportunities they have with Microsoft. Throughout the year, I will be hosting workshops, working with tech evangelists, and contributing to the community of developers at the University of Washington." });
            Experience.Add(new Experience { title = "Xamarin Student Partner", description = "As a part of the Xamarin Student Partner program, I represent Xamarin to spread native C# mobile development at the University of Washington, while also working to become a Xamarin Certified Mobile Developer. Throughout the year, I will be developing solutions and hosting workshops that showcase the Xamarin Platform." });

            Introduction = new Introduction { firstName = "Abhishek", lastName = "Joshi", description = "I love making applications and solving technical problems. As a sophomore at the University of Washington, I enjoy studying informatics and business while taking advantage of the incredible technology and entrepreneurship opportunities on campus." };

            Projects = new List<Project>();

            Projects.Add(new Project { title = "Collab", description = "Developing a web app for people to build and share collaborative playlists with the Spotify API, Firebase, and AngularJS.", type = "Personal" });
            Projects.Add(new Project { title = "Stories", description = "Creating a service for people to share their travels across the web and mobile devices using Xamarin, Azure, AngularJS, and Parse.", type = "Personal" });
            Projects.Add(new Project { title = "Caff-It-Up", description = "Developed a web service with four others that gives an individual a caffeine consumption schedule to reach an optimal level of energy. I also made a companion Windows mobile application.", type = "Personal" });
            Projects.Add(new Project { title = "Trackr", description = "Created a web app using Firebase and jQuery that tracks and visualizes a person’s week based on the time they spend in locations in relation to saved places like “home” and “work.”", type = "Personal" });
            Projects.Add(new Project { title = "Task Hub", description = "Made a Windows mobile app that allows users to create tasks and manage their different sub-items and timings. Currently extending to Android and iOS with Xamarin and Azure.", type = "Personal" });
            Projects.Add(new Project { title = "Your Inventory", description = "Created a web app that allows users to store information about items and search for specific items using MySQL and PHP.", type = "Personal" });

            Projects.Add(new Project { title = "IQuiz", description = "Developing a three-phase iOS mobile app for users to take quizzes on current topics.", type = "Course" });
            Projects.Add(new Project { title = "Tech Review", description = "Created a web app that allows people to submit reviews for a technology product using Parse and jQuery.", type = "Course" });
            Projects.Add(new Project { title = "Spotify DJ", description = "Made a web app for people to add and upvote tracks to a global playlist with Spotify and Firebase.", type = "Course" });
            Projects.Add(new Project { title = "Artifact Hub", description = "Made a web app for people to add and upvote tracks to a global playlist with Spotify and Firebase.", type = "Course" });
            Projects.Add(new Project { title = "Simple Calc", description = "Created an OS X terminal application to represent a simple user calculator in Swift, and later made in to an iOS mobile app.", type = "Course" });
            Projects.Add(new Project { title = "Film Studio", description = "Developed a relational database using SQL Server with three other students for film studios to manage their facilities, equipment, and projects.", type = "Course" });

            Skills = new List<Skill>();

            Skills.Add(new Skill { title = "Web", description = "Utilized jQuery, ASP.NET MVC, Bootstrap, and AngularJS. Currently learning D3 and ReactJS." });
            Skills.Add(new Skill { title = "Mobile", description = "Familiar with Windows, Android, and Xamarin. Learning iOS and Swift development." });
            Skills.Add(new Skill { title = "Data", description = "Created relational database systems with SQL using SQL Server and MySQL." });
            Skills.Add(new Skill { title = "Cloud", description = "Understanding of cloud backend services including Parse, Firebase, and Azure." });
            Skills.Add(new Skill { title = "Code", description = "Background in object-oriented programming with data structures and algorithms." });

        }

    }
}
