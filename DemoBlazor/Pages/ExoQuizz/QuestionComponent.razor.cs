using DemoBlazor.Models;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.Tracing;

namespace DemoBlazor.Pages.ExoQuizz
{
    public partial class QuestionComponent: ComponentBase
    {
        [Parameter]
        public string PseudoParticipant { get; set; }

        [Parameter]
        public EventCallback FinDesQuestion { get; set; }
        [Parameter]
        public EventCallback<string> EnvoiReponse { get; set; }

        public List<Question> Questions { get; set; }
        public int IndexQuestion { get; set; }

		protected override void OnInitialized()
        {
            Questions = new List<Question>();
            Questions.Add(new Question("Avez-vous réussi l'exercice ?"));
            Questions.Add(new Question("Vous avez bien mangé", 
                                        new List<string>() { "Oui", "Ne se prononce pas", "Non"}));


			IndexQuestion = 0;
        }

        public void Repondre(string value)
        {
            EnvoiReponse.InvokeAsync(value);
            IndexQuestion++;
            if (IndexQuestion >= Questions.Count)
            {
                SignalerFinDuQuizz();
            }
        }
        public void SignalerFinDuQuizz()
        {
            FinDesQuestion.InvokeAsync();
        }
    }
}
