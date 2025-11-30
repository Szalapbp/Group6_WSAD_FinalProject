using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group6_WSAD_FinalProject.Models;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class BellaController: Controller
    {
        private readonly AppDbContext _context;

        public BellaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult AboutBella()
        {
            return View("~/Views/Bella/AboutBella.cshtml");
        }
        public IActionResult BellaHobbies()
        {
            var hobbies = _context.Hobbies
            .Where(h => h.OwnerId == 1) 
            .ToList();


            return View(hobbies);
        }
    }
}
