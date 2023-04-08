namespace NutriApp.web.Models
{
    public class Refeicao
    {
        public int RefeicaoId { get; set; }
        public string Descricao { get; set; }
        public decimal qntidadeMaxCalorias { get; set; }
        public List<Alimento> Alimentos { get; set; }
        
        public ICollection<DietaRefeicao> Refeicoes { get; set; }
        public ICollection<RefeicaoAlimento> RefeicaoAlimentos { get; set; }

    }
    
}
