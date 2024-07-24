using MediatR;

namespace BackHackathon.Application.Commands.EfetuarLoginSandbox;

public class EfetuarLoginSandboxCommand : IRequest<EfetuarLoginSandboxResponse>
{
    public string Usuario { get; set; }
    public string Senha { get; set; }
}