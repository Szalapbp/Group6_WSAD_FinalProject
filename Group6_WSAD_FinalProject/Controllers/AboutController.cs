using Microsoft.AspNetCore.Mvc;

namespace Group6_WSAD_FinalProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View("~/Views/About/MeetTheTeam.cshtml");
        }

    }
}
