using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
	public partial class Demo4: ComponentBase
	{
		public List<int> MesNombres { get; set; }

		protected override void OnInitialized()
		{
			MesNombres = new List<int>();
			for(int i = 0; i < 100; i++)
			{
				MesNombres.Add(i);
			}
		}
	}
}
