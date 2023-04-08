namespace NutriApp.web.Models
{
    public class RefeicaoAlimento
    {
        // Chave estrangeira para a refeição
        public int RefeicaoId { get; set; }
        public Refeicao Refeicao { get; set; }

        // Chave estrangeira para o alimento
        public int AlimentoId { get; set; }
        public Alimento Alimento { get; set; }

        // Quantidade do alimento na refeição
        public decimal Quantidade { get; set; }
    }
}
