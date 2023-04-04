using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalManagement_WebSite_V1.Data;
using RentalManagement_WebSite_V1.Models;

namespace RentalManagement_WebSite_V1.Controllers
{
    public class ManagersController : Controller
    {
        // Inject the AppDBContext to the constructor
        private readonly AppDbContext _context;

        public ManagersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allManagers = _context.Managers.ToList();
            return View(allManagers);
        }

        
        // ===========================     DETAILS     ==================================
        // GET: managers/details/id
        public async Task<IActionResult> Details(int id)
        {
            var managerDetails = await _context.Managers.FirstOrDefaultAsync(n => n.ManagerId == id);

            if (managerDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(managerDetails);
            }
        }
        // ============================     CREATE     ===============================
        // Get: manager/create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Manager manager)
        {
            if (ModelState.IsValid)
            {
                return View(manager);
            }
            _context.Add(manager);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // ============================     UPDATE     ===============================
        // Get: manager/edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var managerDetails = await _context.Managers.FirstOrDefaultAsync(n => n.ManagerId == id);

            if (managerDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(managerDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Manager manager)
        {
            if (ModelState.IsValid)
            {
                return View(manager);
            }

            if (id == manager.ManagerId)
            {
                _context.Update(manager);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(manager);
            
        }


        // ============================     DELETE     ===============================

        // Get: manager/delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var managerDetails = await _context.Managers.FirstOrDefaultAsync(n => n.ManagerId == id);
            return View(managerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var managerDetails = await _context.Managers.FirstOrDefaultAsync(n => n.ManagerId == id);
            if (managerDetails == null) return View("Not Found");

            _context.Remove(managerDetails);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
