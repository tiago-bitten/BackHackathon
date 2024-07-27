using System.Threading.Tasks;
using BackHackathon.Application.DTOs;
using BackHackathon.Application.DTOs.resto;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services
{
    public class OnboardingConfigService
    {
        private readonly ILoginSandboxService _loginSandboxService;
        private readonly IModalidadeService _modalidadeService;
        private readonly IContratoService _contratoService;
        private readonly IConfigAvaliacaoFisicaService _configAvaliacaoFisicaService;
        private readonly IConfigCaixaService _configCaixaService;

        public OnboardingConfigService(
            ILoginSandboxService loginSandboxService,
            IModalidadeService modalidadeService,
            IContratoService contratoService,
            IConfigAvaliacaoFisicaService configAvaliacaoFisicaService,
            IConfigCaixaService configCaixaService)
        {
            _loginSandboxService = loginSandboxService;
            _modalidadeService = modalidadeService;
            _contratoService = contratoService;
            _configAvaliacaoFisicaService = configAvaliacaoFisicaService;
            _configCaixaService = configCaixaService;
        }

        public async Task PerformOnboardingConfig(
            ModalidadeDTO modalidadeDto,
            ContratoDTO contratoDto,
            ConfigAvaliacaoFisicaDTO configAvaliacaoFisicaDto,
            ConfigCaixaDTO configCaixaDto,
            UsuarioRecebimentoCaixaDTO usuarioRecebimentoCaixaDto)
        {
            await _loginSandboxService.Login();

            var modalidade = new Modalidade
            {
                Descricao = modalidadeDto.Descricao
            };

            var modalidadeCriada = await _modalidadeService.Criar(modalidade);

            var contrato = new Contrato
            {
                Descricao = contratoDto.Descricao,
                TipoDuracao = contratoDto.TipoDuracao,
                TempoDuracao = contratoDto.TempoDuracao,
                ValorTotal = contratoDto.ValorTotal
            };

            foreach (var modalidadeContratoDto in contratoDto.Modalidades)
            {
                var contratoModalidade = new ContratoModalidade
                {
                    CodigoModalidade = modalidadeCriada.Id
                };
                contrato.Modalidades.Add(contratoModalidade);
            }

            await _contratoService.Criar(contrato);

            var configAvaliacaoFisica = new ConfigAvaliacaoFisica
            {
                TipoUnidadeMedidaAltura = configAvaliacaoFisicaDto.TipoUnidadeMedidaAltura,
                CalculaImc = configAvaliacaoFisicaDto.CalculaImc,
                CalculaPesoIdeal = configAvaliacaoFisicaDto.CalculaPesoIdeal,
                QtdeDiasProximaAvaliacao = configAvaliacaoFisicaDto.QtdeDiasProximaAvaliacao
            };

            await _configAvaliacaoFisicaService.Configurar(configAvaliacaoFisica);

            var configCaixa = new ConfigCaixa
            {
                EnviarRelFechamentoParaUsuariosEnvolvidos = configCaixaDto.EnviarRelFechamentoParaUsuariosEnvolvidos,
                PermiteAbrirMultiplosCaixas = configCaixaDto.PermiteAbrirMultiplosCaixas
            };

            await _configCaixaService.Configurar(configCaixa);

            var usuarioRecebimentoCaixa = new UsuarioRecebimentoCaixa
            {
                CodigoUsuario = usuarioRecebimentoCaixaDto.CodigoUsuario,
                CodigoConfigCaixa = usuarioRecebimentoCaixaDto.CodigoConfigCaixa
            };

            await _configCaixaService.ConfigurarNotificarUsuarioFechamento(usuarioRecebimentoCaixa);
        }
    }
}
