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
    }
}
