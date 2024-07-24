using MediatR;

namespace BackHackathon.Domain.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioQuery : IRequest<GetRecuperarAmbienteUsuarioResponse>
{
    public string Authorization { get; set; }    
    public int CodigoUsuario { get; set; }
    public int CodigoUnidade { get; set; }
}