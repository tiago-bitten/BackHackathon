using BackHackathon.Application.Auth;
using BackHackathon.Application.Auth.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackHackathon.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IAuthAppService _authAppService;
    
    public AuthController(IAuthAppService authAppService)
    {
        _authAppService = authAppService;
    }
    
    [HttpPost(Name = "Login")]
    public async Task<IActionResult> Login(LoginRequestDto request)
    {
        var result = await _authAppService.EfetuarLogin(request);
        return Ok(result);
    }
}