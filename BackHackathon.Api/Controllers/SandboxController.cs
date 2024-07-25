using BackHackathon.Application.Commands.EfetuarLoginSandbox;
using BackHackathon.Application.Queries.GetRecuperarAmbienteUsuario;
using BackHackathon.Application.Queries.GetRecuperarEnums;
using BackHackathon.Application.Queries.GetRecuperarRecursos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackHackathon.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SandboxController : ControllerBase
{
    private readonly IMediator _mediator;

    public SandboxController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost(Name = "Login")]
    public async Task<IActionResult> Login(EfetuarLoginSandboxCommand command)
    {
        var response = await _mediator.Send(command);
        return Ok(response);
    }
    
    [HttpGet(Name = "GetAmbienteUsuario")]
    public async Task<IActionResult> GetAmbienteUsuario([FromQuery] GetRecuperarAmbienteUsuarioQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet(Name = "GetEnums")]
    public async Task<IActionResult> GetEnums([FromQuery] GetRecuperarEnumsQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpGet(Name = "GetRecuperarRecursos")]
    public async Task<IActionResult> GetRecuperarRecursos([FromQuery] GetRecuperarRecursosQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}