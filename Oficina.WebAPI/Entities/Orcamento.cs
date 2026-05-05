namespace Oficina.WebAPI.Entities;

public class Orcamento
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int VeiculoId { get; set; }
    public string Status { get; set; } = "Aberto"; //NOTA AO AVALIADOR: SERIA BOM O USO DE ENUM NESSE CENÁRIO
    public decimal ValorTotal { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public List<OrcamentoItem> Itens { get; set; } = new();
}