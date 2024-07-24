using BackHackathon.Application.Exemplo;
using BackHackathon.Application.Exemplo.Dtos;
using BackHackathon.Domain.Queries.GetRecuperarAmbienteUsuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackHackathon.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ExemploController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IExemploAppService _exemploAppService;

    public ExemploController(IExemploAppService exemploAppService,
        IMediator mediator)
    {
        _mediator = mediator;
        _exemploAppService = exemploAppService;
    }

    [HttpGet(Name = "GetAmbienteUsuario")]
    public async Task<IActionResult> GetAmbienteUsuario([FromQuery] GetRecuperarAmbienteUsuarioQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet(Name = "GetEnums")]
    public async Task<IActionResult> GetEnums([FromQuery] EnumsRequestDto request)
    {
        var result = await _exemploAppService.RecuperarEnums(request);
        return Ok(result);
    }
}