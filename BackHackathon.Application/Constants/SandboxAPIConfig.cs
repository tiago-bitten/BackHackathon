namespace BackHackathon.Application.Constants
{
    public static class SandboxApiConfig
    {
        public static class BaseUrl
        {
            public const string ApiBase = "https://api.sandbox.appnext.fit/api";
        }
        
        public static class Endpoints
        {
            public const string EnumRecuperarTodos = $"{BaseUrl.ApiBase}/Enum/RecuperarTodos";
            public const string UsuarioRecuperarAmbienteUsuario = $"{BaseUrl.ApiBase}/usuario/RecuperarAmbienteUsuario";
            public const string Token = $"{BaseUrl.ApiBase}/token";
        }

        public static class Headers
        {
            public const string CodigoUnidade = "CodigoUnidade";
            public const string CodigoUsuario = "CodigoUsuario";
        }
    }
}