using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalManagement_WebSite_V1.Data;
using RentalManagement_WebSite_V1.Models;

namespace RentalManagement_WebSite_V1.Controllers
{
    public class BuildingsController : Controller
    {
        // Inject the AppDBContext to the constructor
        private readonly AppDbContext _context;

        public BuildingsController(AppDbContext context)
        {
            _context = context;
        }

        // ============================     LIST OF BUILDINGS     ========================
        public IActionResult Index()
        {
            var allBuildings = _context.Buildings.ToList();
            return View(allBuildings);
        }


        // ============================     CREATE     ===============================
        // Get: building/create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Building building)
        {
            if (ModelState.IsValid)
            {
                return View(building);
            }
            _context.Add(building);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // ============================     UPDATE     ===============================
        // Get: building/edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var buildingDetails = await _context.Buildings.FirstOrDefaultAsync(n => n.BuildingId == id);

            if (buildingDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(buildingDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Building building)
        {
            if (ModelState.IsValid)
            {
                return View(building);
            }

            if (id == building.BuildingId)
            {
                _context.Update(building);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(building);

        }


        // ============================     DELETE     ===============================

        // Get: building/delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var buildingDetails = await _context.Buildings.FirstOrDefaultAsync(n => n.BuildingId == id);
            return View(buildingDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buildingDetails = await _context.Buildings.FirstOrDefaultAsync(n => n.BuildingId == id);
            if (buildingDetails == null) return View("Not Found");

            _context.Remove(buildingDetails);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        // ===========================     DETAILS     ==================================
        // GET: building/details/id
        public async Task<IActionResult> Details(int id)
        {
            var buildingDetails = await _context.Buildings.FirstOrDefaultAsync(n => n.BuildingId == id);

            if (buildingDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(buildingDetails);
            }
        }
    }
}
