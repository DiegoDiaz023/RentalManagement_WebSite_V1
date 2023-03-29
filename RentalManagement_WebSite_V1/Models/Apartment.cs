using RentalManagement_WebSite_V1.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalManagement_WebSite_V1.Models
{
    public class Apartment
    {
        [Key]
        public int ApartmentId { get; set; }
        public int AptNumber { get; set; }
        public string Description { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public Utilities Utilities { get; set; }
        public Features Features { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Rented { get; set; }


        // Relationships


        public List<Tenant_Apt> Tenant_Apts { get; set; }
        
        
        // Building
        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }

        // Manager
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public Manager Manager { get; set; }
    }
}
