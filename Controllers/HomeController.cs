using Bincom_CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bincom_CV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cv = new CV
            {
                Name = "Mustapha Babatunde",
                Email = "fawazboluwatife7@gmail.com",
                Phone = "+2348130456471",
                Profile = "Experienced fullstack software developer with expertise in Azure",
               


                EducationHistory = new List<Education>
                {
                new Education
                {
                    Institution = "University of Ilorin",
                    Degree = "Bachelor of Science in Computer Science",
                    Duration = "2014 - 2018"
                }
                }
            };

            return View(cv);

        }


        public IActionResult Experience()
        {
            List<WorkExperience> experience = new List<WorkExperience>
            {
                new WorkExperience
                {

                   Company = "Compuclick Software Solutions",
                    Position = "Intermediate C# Developer",
                    Duration = "Jan 2024 - Present",
                    Responsibilities = "Developed mobile applications using Flutter, deployed on Google Play and App Store"
                 },
               
                  new WorkExperience
                {
                      Company = "Decagon",
                    Position = "Associate Software Engineer",
                    Duration = "2023 – present",
                    Responsibilities = "A member of a team developing, architecting and implementing backend APIs.\r\n •\r\n Developed, designed and maintained scalable monolithic and micro service \r\nbackend systems, resulting in an improvement in system performance.\r\n •\r\n Demonstrated solid understanding of algorithms and data structures to solve \r\ncomplex technical business requirements leading to efficient and clean code.\r\n •\r\n Utilized various SQL databases for efficient data storage and retrieval, while \r\nproviding administrative support to improving performance and response time.\r\n Support troubleshooting and testing of implementations.\r\n •\r\n Mentored junior engineers."
                }

            };



            return View(experience);
        }


        public IActionResult Skills()
        {
            List<Skill> skill = new List<Skill>
            {
               new Skill
               { name   ="C#",
                   skills= " Comfortable with object-oriented programming concepts.\n\nExperience in building desktop and web applications using C#.\r\nFamiliar with async/await for asynchronous programming.\r\nAbility to debug, test, and refactor C# code effectively."
               },

               new Skill
               {
                   name   ="ASP.NET Core",
                   skills= "Experience in creating RESTful APIs and web applications.\r\nUnderstanding of middleware, dependency injection, and routing.\r\nFamiliarity with Entity Framework for database interactions.\r\nExperience in using authentication and authorization features."
               },
                new Skill
               {     name = "SQL",
                   skills= "Competent in writing complex queries and stored procedures.\r\nKnowledge of relational database design and normalization.\r\nAbility to optimize queries for performance.\r\nExperience with database management and migrations.\r\n"
               },
                 new Skill
               {name = "React",
                   skills= "Comfortable with functional components, hooks, and state management.\r\nExperience with React Router for handling navigation.\r\nFamiliar with integrating third-party libraries and APIs.\r\nBasic understanding of component lifecycle and conditional rendering.\r\n"
               },
                  new Skill
               {name = "Tailwind",
                   skills= "Ability to style components using utility-first classes.\r\nKnowledge of responsive design and CSS best practices.\r\nFamiliarity with customizing Tailwind configuration for specific needs.\r\nExperience with dark mode and theming.\r\n"
               },
                   new Skill
               {name = "Flutter",
                   skills= "Experience in building cross-platform mobile applications.\r\nFamiliarity with widgets, state management, and navigation.\r\nAbility to integrate Firebase and other APIs.\r\nBasic understanding of animations and custom UI designs.\r\n\r\n\r\n\r\n\r\n\r\n"
               }
            };

            return View(skill);
        }


        public IActionResult Education()
        {
            List<Education> educations = new List<Education>
            {
                 new Education
                {
                    Institution = "University of Ilorin",
                    Degree = "Bachelor of Science in Computer Science",
                    Duration = "2014 - 2018"
                }
            };
            return View(educations);
        }

        public IActionResult TaxCalculator()
        {
            return View();
        }

       [HttpPost]
        public IActionResult TaxCalculator(decimal salary) {

            decimal tax = salary * 0.07m;

            decimal calculatedSalary = salary - tax;

            ViewBag.Salary = salary;
            ViewBag.Tax = tax;
            ViewBag.Balance = calculatedSalary;


            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}