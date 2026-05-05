namespace Oficina.WebAPI.DTOs
{
    public class ItemRequest
    {
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
