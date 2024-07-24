using System.Text.Json.Serialization;
using BackHackathon.Application.Exemplo.Dtos;
using BackHackathon.Domain.Dtos;

namespace BackHackathon.Domain.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioResponse
{
    public ApiBaseResponse<RecuperarAmbienteUsuarioDTO> ApiBaseResponse { get; set; }
}