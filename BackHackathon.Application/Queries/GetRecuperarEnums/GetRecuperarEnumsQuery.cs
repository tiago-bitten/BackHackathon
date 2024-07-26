using BackHackathon.Application.Dtos;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarEnums;

public class GetRecuperarEnumsQuery : IRequest<GetRecuperarEnumsResponse>
{
    public string Authorization { get; set; }
}