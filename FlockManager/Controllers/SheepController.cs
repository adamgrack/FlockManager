using FlockManager.Data;
using FlockManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlockManager.Controllers
{
    public class SheepController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SheepController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Sheep> objSheepList = _db.Sheep.ToList();
            return View(objSheepList);
        }

        public IActionResult AddSheep() { 
            return View();
        }
        [HttpPost]
        public IActionResult AddSheep(Sheep sheep)
        {
            _db.Sheep.Add(sheep);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
