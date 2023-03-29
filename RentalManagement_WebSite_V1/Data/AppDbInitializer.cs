namespace RentalManagement_WebSite_V1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Add Buildings

                // Add Tenants

                // Add Managers

                // Add Apartments

                // Tenants and Apartments

            }
        }
    }
}
