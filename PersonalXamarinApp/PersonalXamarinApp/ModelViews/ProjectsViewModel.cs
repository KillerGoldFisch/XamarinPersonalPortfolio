using PersonalXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalXamarinApp.ModelViews
{
    public class ProjectsViewModel
    {
        public List<Project> Projects { get; set; }

        public ProjectsViewModel()
        {
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
        }
    }
}