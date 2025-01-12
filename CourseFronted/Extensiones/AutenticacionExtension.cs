using Blazored.SessionStorage;
using EntitiesControllers.Entidades;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CourseFronted.Extensiones
{
    public class AutenticacionExtension:AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorageService;
        private ClaimsPrincipal _sininformacion = new ClaimsPrincipal(new ClaimsIdentity());

        public AutenticacionExtension(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public async Task ActualizarEstado(SesionDTO? sesionUsuario)
        {
            ClaimsPrincipal claimsPrincipal;
            if(sesionUsuario!=null)
            {
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim("UsuarioID",sesionUsuario.UserID),
                    new Claim(ClaimTypes.Name,sesionUsuario.Nombre),
                    new Claim(ClaimTypes.Email,sesionUsuario.Correo),
                    new Claim(ClaimTypes.Role,sesionUsuario.Rol)
                }, "JwtAuth"));
            }
            else
            {
                claimsPrincipal=_sininformacion;
                await _sessionStorageService.RemoveItemAsync("sesionUsuario");
            }
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var sesionUsuario = await _sessionStorageService.ObtenerStorage<SesionDTO>("sesionUsuario");
            if (sesionUsuario == null)
                return await Task.FromResult(new AuthenticationState(_sininformacion));

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim("UsuarioID",sesionUsuario.UserID),
                    new Claim(ClaimTypes.Name,sesionUsuario.Nombre),
                    new Claim(ClaimTypes.Email,sesionUsuario.Correo),
                    new Claim(ClaimTypes.Role,sesionUsuario.Rol)
                }, "JwtAuth"));
            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }
    }
}
