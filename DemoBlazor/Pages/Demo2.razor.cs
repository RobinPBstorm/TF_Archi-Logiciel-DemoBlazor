using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
	public partial class Demo2: ComponentBase
	{
		[Inject]
		private NavigationManager _navigation { get; set; }

		public void redirigerVersCounter()
		{
			_navigation.NavigateTo("/counter");
		}
	}
}
