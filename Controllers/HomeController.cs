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
                 Name= "Mustapha Babatunde",
                Email = "fawazboluwatife7@gmail.com",
                Phone = "+2348130456471",
                Profile = "Experienced fullstack software developer with expertise in Azure",
                Skills = new List<string> { "C#", "ASP.NET Core", "Azure", "SQL", "JavaScript", "React", "Tailwind", "FLutter" },
                WorkExperiences = new List<WorkExperience>
            {
                new WorkExperience
                {
                    Company = "Compuclick Software Solutions",
                    Position = "Intermediate c# Developer",
                    Duration = "Jan 2024 - Present",
                    Responsibilities = "Developed mobile applications using flutter which was deployed on google and applestore respectively"
                },
                new WorkExperience
                {
                    Company = "Decagon Institute",
                    Position = "Intermediate c# Developer",
                    Duration = "Jan 2018 - Dec 2019",
                    Responsibilities = "Worked on backend development using C# and created RESTful API's"
                }
            },
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