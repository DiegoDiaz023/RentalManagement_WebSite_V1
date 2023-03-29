using System.ComponentModel.DataAnnotations;

namespace RentalManagement_WebSite_V1.Models
{
    public class Tenant
    {

        [Key]
        public int TenantId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        // Relationships
        public List<Tenant_Apt> Tenant_Apts { get; set; }

    }
}
