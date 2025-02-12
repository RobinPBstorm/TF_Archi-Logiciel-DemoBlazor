using System.ComponentModel.DataAnnotations;

namespace DemoBlazor.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Le nom est requis!")]
        public string Nom { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'email' est requis!")]
        [EmailAddress(ErrorMessage = "Ce n'est pas une adresse mail valide!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le numéro de téléphone est requis!")]
        [Phone(ErrorMessage = "Ce n'est pas un numéro de téléphone valide!")]
        public string Telephone { get; set; } = string.Empty;


        [Required(ErrorMessage = "Votre message est requis!")]
        public string Message { get; set; } = string.Empty;

        public string CouleurPreferee { get; set; } = string.Empty;
    }
}
