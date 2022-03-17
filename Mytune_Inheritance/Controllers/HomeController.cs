using Microsoft.AspNetCore.Mvc;
using Mytune_Inheritance.Models;
using System.Diagnostics;

namespace Mytune_Inheritance.Controllers
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
            var artist1 = new Artist()
            {
                Id = 1,
                Name = "James",

            };
            artist1.Email = artist1.GenerateEmail();
           
            return View(artist1);
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

        public IActionResult test()
        {
            var song = new Song()
            {
                Id = 1,
                Title = "Song1",
                Runtime = 5
            };

            var user = new User()
            {
                Name = "Md",
                Id = 1
            };
            user.Email = user.GenerateEmail();
            user.Collection.Add(song);

            ViewBag.Binge = user.Binge(song);
            return View();
        }

    }
}