using Microsoft.EntityFrameworkCore;
using RentalManagement_WebSite_V1.Models;

namespace RentalManagement_WebSite_V1.Data
{
    public class AppDbContext:DbContext
    {
        private readonly AppDbContext _context;

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant_Apt>().HasKey(ta => new
            {
                ta.TenantId,
                ta.ApartmentId
            });

            modelBuilder.Entity<Tenant_Apt>().HasOne(a => a.Apartment).WithMany(ta => ta.Tenant_Apts).HasForeignKey(a => a.ApartmentId);
            modelBuilder.Entity<Tenant_Apt>().HasOne(a => a.Tenant).WithMany(ta => ta.Tenant_Apts).HasForeignKey(a => a.TenantId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Tenant_Apt> Tenants_Apts { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Manager> Managers { get; set; }

        /*
        public Task<Tenant> GetById (int id)
        {
            var result = _context.Tenants.FirstOrDefaultAsync(n => n.TenantId == id);
            return result;
        }
        

        public IEnumerable<Tenant> GetAll()
        {
            var result = _context.Tenants.ToList();
            return result;
        }
        */

    }
}
