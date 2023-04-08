namespace NutriApp.web.Models
{
    public class Alimento
    {
        public int AlimentoId { get; set; }
        public string AlimentoName { get; set; }
        public string Descricao { get; set; }
        public decimal Calorias { get; set; }
        public decimal Proteinas { get; set; }
        public Refeicao RefeicaoId { get; set; }
        public ICollection<Refeicao> Refeicao { get;}
        public ICollection<RefeicaoAlimento> RefeicaoAlimentos { get; set; }
    }
}
