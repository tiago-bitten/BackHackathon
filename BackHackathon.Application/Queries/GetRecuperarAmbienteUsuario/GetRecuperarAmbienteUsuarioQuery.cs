using BackHackathon.Domain.Dtos;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioQuery : IRequest<GetRecuperarAmbienteUsuarioResponse<RecuperarAmbienteUsuarioDTO>>
{
    public string Authorization { get; set; }    
    public int CodigoUsuario { get; set; }
    public int CodigoUnidade { get; set; }
}