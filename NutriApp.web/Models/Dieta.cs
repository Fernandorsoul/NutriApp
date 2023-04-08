using NutriApp.web.Enums;

namespace NutriApp.web.Models
{
    public class Dieta
    {
        public int DietaId { get; set; }
        public string Nome { get; set; }
        public string Description { get; set; }
        public TipoDeDieta TipoDeDieta { get; set; }
        public ICollection<Refeicao> Refeicoes { get; set; }
        public ICollection<DietaRefeicao> DietaRefeicoes { get; set; }

        

        
    }
}
