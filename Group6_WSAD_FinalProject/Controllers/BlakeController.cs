using Microsoft.AspNetCore.Mvc;
using Group6_WSAD_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class BlakeController : Controller
    {
        private readonly AppDbContext _context;

        public BlakeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult AboutBlake()
        {
            return View();
        }
        public IActionResult BlakeHobbies()
        {
            var hobbies = _context.Hobbies
            .Where(h => h.OwnerId == 2)
            .ToList();
            return View(hobbies);
        }
    }
}
