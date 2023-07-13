using System.ComponentModel.DataAnnotations;

namespace ProjetLabo.Api.Models.Forms
{
#nullable disable
    public class UpdateClientForm
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Nom_Societe { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Num_Tva { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Pays { get; set; }
    }
}
