using System.ComponentModel.DataAnnotations;

namespace RentalManagement_WebSite_V1.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Building Name")]
        public string BuildingName { get; set; }

        [Display(Name = "Bureau")]
        public string Bureau { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }


        // Relationships One Building per Aparment
        public List<Apartment> Apartments { get; set; }

    }
}
