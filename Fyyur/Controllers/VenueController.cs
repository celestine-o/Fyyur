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
    }
}
