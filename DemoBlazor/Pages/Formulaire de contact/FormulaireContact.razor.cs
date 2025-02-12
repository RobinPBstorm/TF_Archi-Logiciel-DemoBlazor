using DemoBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Formulaire_de_contact
{
    public partial class FormulaireContact: ComponentBase
    {
        public Contact ContactModel { get; set; } = new Contact();

        public string RetourValidation { get; set; } = string.Empty;
        public bool FormulaireInvalid { get; set; } = true;

        public void SignalerInvalideFormulaire()
        {
            FormulaireInvalid = true;
            RetourValidation = "Veuillez vérifier le formulaire";
        }
        public void EnvoyerFormulaire()
        {
            FormulaireInvalid = false;
            RetourValidation = "SUCCESS";
        }
    }
}
