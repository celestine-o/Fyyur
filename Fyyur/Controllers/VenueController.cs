using Fyyur.Models;
using Fyyur.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Fyyur.Controllers
{
    public class VenueController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VenueController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Venue> objVenueList = _db.Venues.ToList();
            return View(objVenueList);
        }

        public IActionResult ViewDetails(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Venue? venueById = _db.Venues.Find(id);
            if (venueById == null)
            {
                return NotFound();
            }
            return View(venueById);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Venue? venueById = _db.Venues.Where(Venue => Venue.Id == id).FirstOrDefault();
            if (venueById == null)
            {
                return NotFound();
            }
            return View(venueById);
        }

        [HttpPost]
        public IActionResult Edit(Venue obj)
        {
            if (ModelState.IsValid)
            {
                _db.Venues.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Venue updated successfully";
                return RedirectToAction("Index", "Venue");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id.Value == 0)
            {
                return NotFound();
            }
            Venue? venueById = _db.Venues.Where(Venue => Venue.Id == id).FirstOrDefault();
            if (venueById == null)
            {
                return NotFound();
            }
            return View(venueById);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Id)
        {
            Venue? venueById = _db.Venues.Where(u => u.Id == Id).FirstOrDefault();
            if (venueById == null)
            {
                NotFound();
            }
            _db.Venues.Remove(venueById);
            _db.SaveChanges();
            TempData["success"] = "Venue deleted successfully";
            return RedirectToAction("Index", "Venue");
        }
    }
}
