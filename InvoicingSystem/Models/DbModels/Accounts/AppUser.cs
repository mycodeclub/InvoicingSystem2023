using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InvoicingSystem.Models.DbModels.Accounts
{
    public class AppUser : IdentityUser
    {
        [Required]
        [DisplayName("Organization Name")]
        public string OrganizationName { get; set; } = string.Empty;
        [NotMapped]
        public string Password { get; set; } = string.Empty;
        [NotMapped]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }
    }
}
