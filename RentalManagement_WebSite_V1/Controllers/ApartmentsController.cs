using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalManagement_WebSite_V1.Data;

namespace RentalManagement_WebSite_V1.Controllers
{
    public class ApartmentsController : Controller
    {

        // Inject the AppDBContext to the constructor
        private readonly AppDbContext _context;

        public ApartmentsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allApartments = _context.Apartments.Include(n => n.Building).ToList();
            return View("Index1", allApartments);
        }
    }
}
