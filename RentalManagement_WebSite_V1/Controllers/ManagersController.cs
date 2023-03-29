using Microsoft.AspNetCore.Mvc;
using RentalManagement_WebSite_V1.Data;

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
    }
}
