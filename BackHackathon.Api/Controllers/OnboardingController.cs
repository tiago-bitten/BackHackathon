using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;
using Microsoft.AspNetCore.Mvc;
using BackHackathon.Application.DTOs;
using BackHackathon.Application.DTOs.resto;

namespace BackHackathon.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OnboardingController : ControllerBase
    {
        private readonly ILoginSandboxService _login;
        private readonly IModalidadeService _modalidadeService;
        private readonly IContratoService _contratoService;
        private readonly IConfigAvaliacaoFisicaService _configAvaliacaoFisicaService;
        private readonly IConfigCaixaService _configCaixaService;

        public OnboardingController(ILoginSandboxService login,
            IModalidadeService modalidadeService,
            IContratoService contratoService,
            IConfigAvaliacaoFisicaService configAvaliacaoFisicaService,
            IConfigCaixaService configCaixaService)
        {
            _login = login;
            _modalidadeService = modalidadeService;
            _contratoService = contratoService;
            _configAvaliacaoFisicaService = configAvaliacaoFisicaService;
            _configCaixaService = configCaixaService;
        }

        [HttpPost]
        public async Task<IActionResult> Login()
        {
            return Ok(await _login.Login());
        }

        [HttpPost]
        public async Task<IActionResult> Modalidade([FromBody] ModalidadeDTO modalidadeDto)
        {
            var modalidade = new Modalidade
            {
                Descricao = modalidadeDto.Descricao
            };

            var modalidadeCriada = await _modalidadeService.Criar(modalidade);

            return Ok(modalidadeCriada);
        }

        [HttpPost]
        public async Task<IActionResult> Contrato([FromBody] ContratoDTO contratoDto)
        {
            var contrato = new Contrato
            {
                Descricao = contratoDto.Descricao,
                TipoDuracao = contratoDto.TipoDuracao,
                TempoDuracao = contratoDto.TempoDuracao,
                ValorTotal = contratoDto.ValorTotal
            };

            foreach (var modalidadeDto in contratoDto.Modalidades)
            {
                var contratoModalidade = new ContratoModalidade
                {
                    CodigoModalidade = modalidadeDto.CodigoModalidade
                };
                contrato.Modalidades.Add(contratoModalidade);
            }

            var contratoCriado = await _contratoService.Criar(contrato);

            return Ok(contratoCriado);
        }

        [HttpPost]
        public async Task<IActionResult> ConfigAvaliacaoFisica([FromBody] ConfigAvaliacaoFisicaDTO configDto)
        {
            var config = new ConfigAvaliacaoFisica
            {
                TipoUnidadeMedidaAltura = configDto.TipoUnidadeMedidaAltura,
                CalculaImc = configDto.CalculaImc,
                CalculaPesoIdeal = configDto.CalculaPesoIdeal,
                QtdeDiasProximaAvaliacao = configDto.QtdeDiasProximaAvaliacao
            };

            var configCriada = await _configAvaliacaoFisicaService.Configurar(config);

            return Ok(configCriada);
        }

        [HttpPost]
        public async Task<IActionResult> ConfigCaixa([FromBody] ConfigCaixaDTO configDto)
        {
            var config = new ConfigCaixa
            {
                EnviarRelFechamentoParaUsuariosEnvolvidos = configDto.EnviarRelFechamentoParaUsuariosEnvolvidos,
                PermiteAbrirMultiplosCaixas = configDto.PermiteAbrirMultiplosCaixas
            };

            await _configCaixaService.Configurar(config);

            return Ok("Configuração realizada");
        }

        [HttpPost]
        public async Task<IActionResult> ConfigUsuarioRecebimentoCaixa([FromBody] UsuarioRecebimentoCaixaDTO usuarioDto)
        {
            var usuario = new UsuarioRecebimentoCaixa
            {
                CodigoUsuario = usuarioDto.CodigoUsuario,
                CodigoConfigCaixa = usuarioDto.CodigoConfigCaixa
            };

            await _configCaixaService.ConfigurarNotificarUsuarioFechamento(usuario);

            return Ok("Usuário configurado");
        }
    }
}
