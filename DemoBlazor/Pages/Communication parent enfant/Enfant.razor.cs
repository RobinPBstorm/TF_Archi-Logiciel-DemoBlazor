using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Communication_parent_enfant
{
	public partial class Enfant: ComponentBase
	{
		[Parameter]
        public int ValeurVenantDuParent { get; set; }

		[Parameter]
		public EventCallback<int> ReponseAuParent { get; set; }

		public void EnvoyerReponseAuParent()
		{
			ReponseAuParent.InvokeAsync(ValeurVenantDuParent + 5);
		}
    }
}
