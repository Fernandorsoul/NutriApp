namespace NutriApp.web.Models
{
    public class DietaRefeicao
    {
        public int DietaId { get; set; }
        public Dieta Dieta { get; set; }
        public int RefeicaoID { get; set; }
        public Refeicao refeicao { get; set; }
        
    }
}
