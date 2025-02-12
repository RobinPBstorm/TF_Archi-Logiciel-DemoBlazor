using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
    public partial class Demo3: ComponentBase, IDisposable
    {
		[Parameter]
        public int Valeur { get; set; }

		// A l'initialisation du composant
		protected override void OnInitialized()
		{
			//Valeur = 5;
		}

		// Au moment de la définition des paramètres
		protected override void OnParametersSet()
		{
			Valeur += 5;
		}
		// méthode à déclencher
		public void RefreshPage()
		{
			// forcer un nouveau rendu
			StateHasChanged();
		}
		//Juste après le rendu HTML
		protected override void OnAfterRender(bool firstRender)
		{
			base.OnAfterRender(firstRender);
		}

		// Pour gérer la fin du composant
		// nécessite IDisposable
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
