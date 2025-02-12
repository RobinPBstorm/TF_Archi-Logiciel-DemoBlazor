namespace DemoBlazor.Models
{
    public class Question
    {
        public string Intitule { get; set; } = string.Empty;
        public List<string> Reponses { get; set; } = new List<string>();

        public Question()
        {
            Reponses.Add("Oui");
            Reponses.Add("Non");
        }
		public Question(string intitule)
		{
            Intitule = intitule;
			Reponses.Add("Oui");
			Reponses.Add("Non");
		}


		public Question(string intitule, List<string> reponses)
        {
            Intitule = intitule;
            Reponses = reponses;
        }
    }
}
