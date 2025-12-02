using Group6_WSAD_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class DatasetController : Controller
    {
        private readonly AppDbContext _context;

        public DatasetController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hobbies = _context.Hobbies
                .Include(h => h.Owner)
                .ToList();

            return View("Dataset", hobbies);
        }

    }
}
