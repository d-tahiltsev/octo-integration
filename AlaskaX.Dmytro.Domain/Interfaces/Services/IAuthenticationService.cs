using AlaskaX.Dmytro.Application.Services.DTOs.Authentication;

namespace AlaskaX.Dmytro.Domain.Interfaces.Services
{
    public interface IAuthenticationService
    {
        DTOAuthenticationResponse Authenticate(string aCredential);
    }
}
