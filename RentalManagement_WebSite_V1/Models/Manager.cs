using System.ComponentModel.DataAnnotations;

namespace RentalManagement_WebSite_V1.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        // Relationships One Manager per Apartment
        public List<Apartment> Apartments { get; set; }


    }
}
