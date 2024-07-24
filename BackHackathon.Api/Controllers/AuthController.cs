using BackHackathon.Application.Commands.EfetuarLoginSandbox;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackHackathon.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public AuthController(IMediator mediator)
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