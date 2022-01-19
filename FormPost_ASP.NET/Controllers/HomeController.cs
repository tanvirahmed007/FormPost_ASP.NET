using FormPost_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormPost_ASP.NET.Controllers
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


            return View();
        }

        [HttpPost]

        public IActionResult Index(PersonalModel personal)
        {
            int personId = personal.PersonId;
            string name = personal.Name;
            string gender = personal.Gender;
            string city = personal.City;

            return View();

        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}