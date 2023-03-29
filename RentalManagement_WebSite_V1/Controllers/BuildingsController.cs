using Microsoft.AspNetCore.Mvc;
using RentalManagement_WebSite_V1.Data;

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


        public IActionResult Index()
        {
            var allBuildings = _context.Buildings.ToList();
            return View(allBuildings);
        }
    }
}
