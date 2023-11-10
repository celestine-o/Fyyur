using Fyyur.Models;
using Fyyur.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fyyur.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Show> objShowList = _db.Shows.ToList();
            return View(objShowList);
        }

        public IActionResult Create(Show obj)
        {
            if (ModelState.IsValid)
            {
                _db.Shows.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Show added successfully"; 
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult ViewDetails(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Show? showById = _db.Shows.Find(id);
            if (showById == null)
            {
                return NotFound();
            }
            return View(showById);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Show? showById = _db.Shows.Where(Show => Show.Id == id).FirstOrDefault();
            if (showById == null)
            {
                return NotFound();
            }
            return View(showById);
        }

        [HttpPost]
        public IActionResult Edit(Show obj)
        {
            if (ModelState.IsValid)
            {
                _db.Shows.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Show updated successfully";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Show? showById = _db.Shows.Where(Show => Show.Id == id).FirstOrDefault();
            if (showById == null)
            {
                return NotFound();
            }
            return View(showById);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Id)
        {
            Show? showById = _db.Shows.Where(Show => Show.Id == Id).FirstOrDefault();
            if (showById == null)
            {
                NotFound();
            }
            _db.Shows.Remove(showById);
            _db.SaveChanges();
            TempData["success"] = "Show deleted successfully";
            return RedirectToAction("Index", "Home");
        }

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}