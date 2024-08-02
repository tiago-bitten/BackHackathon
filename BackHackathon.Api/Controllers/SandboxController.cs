using BackHackathon.Application.Commands.EfetuarLoginSandbox;
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
}