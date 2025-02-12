using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
    public partial class Demo1: ComponentBase
    {
        public int Valeur { get; set; } = 5;

        public void Augmenter()
        {
            Valeur++;
        }
        public void Diminuer()
        {
            Valeur--;
        }
    }
}
