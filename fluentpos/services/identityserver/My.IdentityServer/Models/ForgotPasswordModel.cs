using System.ComponentModel.DataAnnotations;

namespace My.IdentityServer.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}