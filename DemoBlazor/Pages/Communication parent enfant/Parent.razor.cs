using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Communication_parent_enfant
{
	public partial class Parent: ComponentBase
	{
		public int Valeur { get; set; } = 5;

		public void RecevoirReponseEnfant(int valeur)
		{
			Valeur = valeur;
		}
    }
}
