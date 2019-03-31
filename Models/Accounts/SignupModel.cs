using System.ComponentModel.DataAnnotations;

namespace Gwasanaeth.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]  
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least six characters long")]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}