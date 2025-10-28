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

        public IActionResult Bella()
        {
            return View();
        }

        public IActionResult Blake()
        {
            return View();
        }

        public IActionResult Brian()
        {
            return View();
        }

        public IActionResult HobbyHome()
        {
            return View();
        }

        public IActionResult Hobby()
        {
            return View();
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
