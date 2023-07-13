using System.ComponentModel.DataAnnotations;

namespace ProjetLabo.Api.Models.Forms
{
#nullable disable
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
