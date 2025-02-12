using DemoBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
	public partial class Demo5: ComponentBase
	{
        public Produit ProduitModel { get; set; } = new Produit();

        public void SignalerLesErreursFormulaires()
        {
            //instructions
        }

        public void EnvoyerFormulaire()
        {

        }
    }
}
