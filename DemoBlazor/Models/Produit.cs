using System.ComponentModel.DataAnnotations;

namespace DemoBlazor.Models
{
    public class Produit
    {
        [Required(ErrorMessage = "Le nom est obligatoire!")]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [Range(0,1000000)]
        public decimal Prix { get; set; } = 0;
        [Required]
        public string Couleur { get; set; } = string.Empty;
    }
}
