using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.ExoQuizz
{
    public partial class GrandQuizz: ComponentBase
    {
        public string Pseudo { get; set; } = string.Empty;
        public List<string> ReponsesRecues { get; set; } = new List<string>();
        public bool QuizzTermine { get; set; } = false;
        public void ReceptionReponse(string reponse)
        {
            ReponsesRecues.Add(reponse);
        }
        public void FinDuQuizz()
        {
            QuizzTermine = true;
        }

	}
}
