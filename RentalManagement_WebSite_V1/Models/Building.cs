using System.ComponentModel.DataAnnotations;

namespace RentalManagement_WebSite_V1.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Display(Name = "Building Name")]
        [Required(ErrorMessage = "Building Name is required")]
        public string BuildingName { get; set; }

        [Display(Name = "Bureau")]
        [Required(ErrorMessage = "Bureau is required")]
        public string Bureau { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }


        // Relationships One Building per Aparment
        public List<Apartment> Apartments { get; set; }

    }
}
