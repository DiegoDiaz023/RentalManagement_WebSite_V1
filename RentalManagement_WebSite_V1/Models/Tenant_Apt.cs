namespace RentalManagement_WebSite_V1.Models
{
    public class Tenant_Apt
    {
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }


        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
