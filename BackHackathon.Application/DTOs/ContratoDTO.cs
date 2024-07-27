using BackHackathon.Domain.Enums;

namespace BackHackathon.Application.DTOs.resto;

public class ContratoDTO
{
    public string Descricao { get; set; }
    public ETipoDuracao TipoDuracao { get; set; }
    public int TempoDuracao { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ContratoModalidadeDTO> Modalidades { get; set; } = new List<ContratoModalidadeDTO>();
}