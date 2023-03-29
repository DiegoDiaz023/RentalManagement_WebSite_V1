using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalManagement_WebSite_V1.Data;
using RentalManagement_WebSite_V1.Models;

namespace RentalManagement_WebSite_V1.Controllers
{
    public class TenantsController : Controller
    {
        private readonly AppDbContext _context;

        public TenantsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allTenants = _context.Tenants.ToList();
            return View(allTenants);
        }

        // Get: Tenant/Create new tenant
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tenant tenant)
        {
            if (ModelState.IsValid)
            {
                return View(tenant);
            }
            _context.Add(tenant);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // Get: Tenant / Details / Get Id from tenant

        public async Task<IActionResult> Details(int id)
        {
            var tenantDetails = await _context.Tenants.FirstOrDefaultAsync(n => n.TenantId == id);

            if (tenantDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(tenantDetails);
            }

        }


        // Get: Tenant / Edit a tenant
        public async Task<IActionResult> Edit(int id)
        {
            var tenantDetails = await _context.Tenants.FirstOrDefaultAsync(n => n.TenantId == id);

            if (tenantDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(tenantDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Tenant tenant)
        {
            if (ModelState.IsValid)
            {
                return View(tenant);
            }
            _context.Update(tenant);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        // Get: Tenant / Delete a tenant
        public async Task<IActionResult> Delete(int id)
        {
            var tenantDetails = await _context.Tenants.FirstOrDefaultAsync(n => n.TenantId == id);

            if (tenantDetails == null)
            {
                return View("Not Found");
            }
            else
            {
                return View(tenantDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tenantDetails = await _context.Tenants.FirstOrDefaultAsync(n => n.TenantId == id);
            //if (tenantDetails == null) return View("Not Found");

            _context.Remove(id);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
