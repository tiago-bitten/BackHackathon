using BackHackathon.Application.DTOs;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarPermissoesUsuarioLogado;

public class
    GetRecuperarPermissoesUsuarioLogadoQuery : IRequest<GetRecuperarPermissoesUsuarioLogadoResponse>
{
    public string Authorization { get; set; }
    public int CodigoUnidade { get; set; }
}