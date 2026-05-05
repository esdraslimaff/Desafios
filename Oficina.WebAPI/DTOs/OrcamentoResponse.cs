namespace Oficina.WebAPI.DTOs
{
    public class OrcamentoResponse
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal ValorTotal { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ItemResponse> Itens { get; set; } = new();
    }
}
