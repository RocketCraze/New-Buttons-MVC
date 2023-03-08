using Graduate_Project___Leon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduate_Project___Leon.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfileController(ApplicationDbContext context)
        {
            _context = context;
        }    
        public IActionResult Index()
        {
            var profiles = _context.Profile.ToList();

            return View(profiles);
        }

        
        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProfile(Profile profile)
        {
            //Console.WriteLine(profile.Name);
            _context.Add(profile);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EditProfile(int ID)
        {
            var profile = _context.Profile.Find(ID);
            return View(profile);
        }

        [HttpPost]
        public IActionResult EditProfile(Profile profile)
        {
            _context.Update(profile);  
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteProfile(int ID)
        {
            var profile = _context.Profile.Find(ID);
            _context.Remove(profile);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        



    }
}
