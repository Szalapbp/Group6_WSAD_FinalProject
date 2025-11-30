using System.Diagnostics;
using Group6_WSAD_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group6_WSAD_FinalProject.Controllers
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
        public IActionResult AboutHome()
        {
            return View();
        }

        public IActionResult AboutBella()
        {
            return View("~/Views/Bella/AboutBella.cshtml");
        }

        public IActionResult AboutBlake()
        {
            return View("~/Views/Blake/AboutBlake.cshtml");
        }

        public IActionResult AboutBrian()
        {
            return View();
        }

        public IActionResult Explore()
        {
            return View("~/Views/Hobbies/Explore.cshtml");
        }


        public IActionResult Dataset()
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
