using Microsoft.AspNetCore.Mvc;
using Group6_WSAD_FinalProject.Models;
using System.Threading.Tasks;
using System.Linq;
using Group6_WSAD_FinalProject.Models.Blake;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class BlakeController : Controller
    {
    

        public IActionResult AboutBlake()
        {
            return View();
        }
        public IActionResult BlakeHobbies()
        {
            return View();
        }
    }
}
