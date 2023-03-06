using Graduate_Project___Leon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graduate_Project___Leon.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ProfileViewModel profile = new ProfileViewModel("Leon", "le Roux", "1993/10/07", 29, "South Africa", "Centurion");
            return View(profile);
        }
    }
}
