using BackHackathon.Application.DTOs;
using BackHackathon.Application.Queries.GetRecuperarEnums;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarRecursos;

public class GetRecuperarRecursosQuery : IRequest<GetRecuperarRecursosResponse>
{
    public string Authorization { get; set; }
    public int CodigoUnidade { get; set; }
}