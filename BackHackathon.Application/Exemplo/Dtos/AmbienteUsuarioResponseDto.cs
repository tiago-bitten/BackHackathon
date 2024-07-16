using System.Text.Json.Serialization;

namespace BackHackathon.Application.Exemplo.Dtos;

public class AmbienteUsuarioResponseDto
{
    [JsonPropertyName("Content")]
    public AmbienteUsuarioContent Content { get; set; }

    [JsonPropertyName("Message")]
    public string Message { get; set; }

    [JsonPropertyName("Success")]
    public bool Success { get; set; }
}

public class ConfigCampoObrigatorio
{
    [JsonPropertyName("Origem")]
    public int Origem { get; set; }

    [JsonPropertyName("NomeDaPropriedade")]
    public string NomeDaPropriedade { get; set; }
}

public class AmbienteUsuarioContent
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("UtilizaMultiUnidade")]
    public bool UtilizaMultiUnidade { get; set; }

    [JsonPropertyName("CodigoCadastro")]
    public int CodigoCadastro { get; set; }

    [JsonPropertyName("CodigoTenant")]
    public int CodigoTenant { get; set; }

    [JsonPropertyName("CodigoUnidade")]
    public int CodigoUnidade { get; set; }

    [JsonPropertyName("CodigoUnidadePreferencial")]
    public int CodigoUnidadePreferencial { get; set; }

    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [JsonPropertyName("Email")]
    public string Email { get; set; }

    [JsonPropertyName("UrlImagem")]
    public string UrlImagem { get; set; }

    [JsonPropertyName("OnboardingCompleto")]
    public bool OnboardingCompleto { get; set; }

    [JsonPropertyName("ControlaGraduacao")]
    public bool ControlaGraduacao { get; set; }

    [JsonPropertyName("UtilizaModuloCross")]
    public bool UtilizaModuloCross { get; set; }

    [JsonPropertyName("ImprimiReciboAutomaticamenteNaVenda")]
    public bool ImprimiReciboAutomaticamenteNaVenda { get; set; }

    [JsonPropertyName("UrlImagemUnidade")]
    public string UrlImagemUnidade { get; set; }

    [JsonPropertyName("TelefoneUnidade")]
    public string TelefoneUnidade { get; set; }

    [JsonPropertyName("NomeFantasiaUnidade")]
    public string NomeFantasiaUnidade { get; set; }

    [JsonPropertyName("EmailUnidade")]
    public string EmailUnidade { get; set; }

    [JsonPropertyName("TipoPerfilAcesso")]
    public int TipoPerfilAcesso { get; set; }

    [JsonPropertyName("QtdeChatsNaoLido")]
    public int QtdeChatsNaoLido { get; set; }

    [JsonPropertyName("TipoEmpresa")]
    public int TipoEmpresa { get; set; }

    [JsonPropertyName("CodigoModeloOperacao")]
    public int CodigoModeloOperacao { get; set; }

    [JsonPropertyName("ModeloOperacao")]
    public string ModeloOperacao { get; set; }

    [JsonPropertyName("CodigoPlano")]
    public int CodigoPlano { get; set; }

    [JsonPropertyName("NomePlano")]
    public string NomePlano { get; set; }

    [JsonPropertyName("DataProvisionamento")]
    public DateTime DataProvisionamento { get; set; }

    [JsonPropertyName("TemFaturasAtrasadas")]
    public bool TemFaturasAtrasadas { get; set; }

    [JsonPropertyName("QtdeClientesAtivos")]
    public int QtdeClientesAtivos { get; set; }

    [JsonPropertyName("FaixaClientesAtivos")]
    public string FaixaClientesAtivos { get; set; }

    [JsonPropertyName("TemCatraca")]
    public bool TemCatraca { get; set; }

    [JsonPropertyName("Ativacao")]
    public bool Ativacao { get; set; }

    [JsonPropertyName("Atencao")]
    public bool Atencao { get; set; }

    [JsonPropertyName("TipoFit")]
    public int TipoFit { get; set; }

    [JsonPropertyName("StatusTenant")]
    public int StatusTenant { get; set; }

    [JsonPropertyName("TemNotaFiscal")]
    public bool TemNotaFiscal { get; set; }

    [JsonPropertyName("TemGympass")]
    public bool TemGympass { get; set; }

    [JsonPropertyName("TemGympassBooking")]
    public bool TemGympassBooking { get; set; }

    [JsonPropertyName("FormaAceiteGympass")]
    public int FormaAceiteGympass { get; set; }

    [JsonPropertyName("TemTotalPass")]
    public bool TemTotalPass { get; set; }

    [JsonPropertyName("TemTotalPassBooking")]
    public bool TemTotalPassBooking { get; set; }

    [JsonPropertyName("CadastraEvolucoesCliente")]
    public bool CadastraEvolucoesCliente { get; set; }

    [JsonPropertyName("FreshChatRestoreId")]
    public string FreshChatRestoreId { get; set; }

    [JsonPropertyName("RealizouTreinamento")]
    public bool RealizouTreinamento { get; set; }

    [JsonPropertyName("AtualizarExercicios")]
    public bool AtualizarExercicios { get; set; }

    [JsonPropertyName("SenhaGlobal")]
    public bool SenhaGlobal { get; set; }

    [JsonPropertyName("TemGradeHorario")]
    public bool TemGradeHorario { get; set; }

    [JsonPropertyName("PermiteAbrirMultiplosCaixas")]
    public bool PermiteAbrirMultiplosCaixas { get; set; }

    [JsonPropertyName("TemReconhecimentoFacial")]
    public bool TemReconhecimentoFacial { get; set; }

    [JsonPropertyName("TemAppMensagens")]
    public bool TemAppMensagens { get; set; }

    [JsonPropertyName("TemSiteVendas")]
    public bool TemSiteVendas { get; set; }

    [JsonPropertyName("TemSiteAgendamentos")]
    public bool TemSiteAgendamentos { get; set; }

    [JsonPropertyName("TemNextFitPay")]
    public bool TemNextFitPay { get; set; }

    [JsonPropertyName("TemPagarme")]
    public bool TemPagarme { get; set; }

    [JsonPropertyName("TemMotorCobranca")]
    public bool TemMotorCobranca { get; set; }

    [JsonPropertyName("TemNextFitPayNotificarDoc")]
    public bool TemNextFitPayNotificarDoc { get; set; }

    [JsonPropertyName("VisualizarParticipantesNaAgenda")]
    public bool VisualizarParticipantesNaAgenda { get; set; }

    [JsonPropertyName("TemRecebaFacil")]
    public bool TemRecebaFacil { get; set; }

    [JsonPropertyName("GatewayRecebaFacil")]
    public int GatewayRecebaFacil { get; set; }

    [JsonPropertyName("Faturas")]
    public object Faturas { get; set; }

    [JsonPropertyName("ConfigCampoObrigatorio")]
    public List<ConfigCampoObrigatorio> ConfigCampoObrigatorio { get; set; }

    [JsonPropertyName("UnidadesPermitidas")]
    public List<UnidadesPermitida> UnidadesPermitidas { get; set; }

    [JsonPropertyName("TermosUsoSistemaWeb")]
    public TermosUsoSistemaWeb TermosUsoSistemaWeb { get; set; }

    [JsonPropertyName("Aviso")]
    public object Aviso { get; set; }

    [JsonPropertyName("NextFitPayNotificarDoc")]
    public object NextFitPayNotificarDoc { get; set; }
}

public class TermosUsoSistemaWeb
{
    [JsonPropertyName("SincronizarTermosUso")]
    public bool SincronizarTermosUso { get; set; }

    [JsonPropertyName("Obrigatorio")]
    public bool Obrigatorio { get; set; }

    [JsonPropertyName("CodigoTermosUso")]
    public int CodigoTermosUso { get; set; }
}

public class UnidadesPermitida
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("Fantasia")]
    public string Fantasia { get; set; }
}