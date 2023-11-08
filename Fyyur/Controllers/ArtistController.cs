using Fyyur.Models;
using Fyyur.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fyyur.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ArtistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Artist> objArtistList = _db.Artists.ToList();
            return View(objArtistList);
        }

        public IActionResult Create(Artist obj)
        {
            if (ModelState.IsValid)
            {
                _db.Artists.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Artist added successfully";
                return RedirectToAction("Index", "Artist");
            }
            return View();
        }

        public IActionResult ViewDetails(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Artist? ArtistById = _db.Artists.Find(id);
            if (ArtistById == null)
            {
                return NotFound();
            }
            return View(ArtistById);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Artist? artistById = _db.Artists.Where(Artist => Artist.Id == id).FirstOrDefault();
            if (artistById == null)
            {
                return NotFound();
            }
            return View(artistById);
        }

        [HttpPost]
        public IActionResult Edit(Artist obj)
        {
            if (ModelState.IsValid)
            {
                _db.Artists.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Artist updated successfully";
                return RedirectToAction("Index", "Artist");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Artist? artistById = _db.Artists.Where(Artist => Artist.Id == id).FirstOrDefault();
            if (artistById == null)
            {
                return NotFound();
            }
            return View(artistById);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Id)
        {
            Artist? artistById = _db.Artists.Where(u => u.Id == Id).FirstOrDefault();
            if (artistById == null)
            {
                NotFound();
            }
            _db.Artists.Remove(artistById);
            _db.SaveChanges();
            TempData["success"] = "Venue deleted successfully";
            return RedirectToAction("Index", "Artist");
        }
    }
}
