using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
	public partial class Counter: ComponentBase
	{
		[Parameter]
        public int valeurDeDepart { get; set; }

        private int currentCount = 0;

		private void IncrementCount()
		{
			currentCount++;
		}
	}
}
