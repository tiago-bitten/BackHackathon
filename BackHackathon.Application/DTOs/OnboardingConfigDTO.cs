using BackHackathon.Application.DTOs.resto;

namespace BackHackathon.Application.DTOs;

public class OnboardingConfigDTO
{
    public ModalidadeDTO Modalidade { get; set; }
    public ContratoDTO Contrato { get; set; }
    public ConfigAvaliacaoFisicaDTO ConfigAvaliacaoFisica { get; set; }
    public ConfigCaixaDTO ConfigCaixa { get; set; }
    public UsuarioRecebimentoCaixaDTO UsuarioRecebimentoCaixa { get; set; }
}