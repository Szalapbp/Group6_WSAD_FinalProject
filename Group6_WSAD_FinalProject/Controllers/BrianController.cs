using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group6_WSAD_FinalProject.Models;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class BrianController : Controller
    {
        private readonly AppDbContext _context;

        public BrianController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult AboutBrian()
        {
            return View("~/Views/Brian/AboutBrian.cshtml");
        }

        public IActionResult BrianHobbies()
        {
            var hobbies = _context.Hobbies
                .Where(h => h.OwnerId == 3) // your OwnerId
                .ToList();

            return View(hobbies);
        }
    }
}
