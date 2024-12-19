using AlaskaX.Dmytro.Application.Services.DTOs.Authentication;
using AlaskaX.Dmytro.Domain.Interfaces.Services;

using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace AlaskaX.Dmytro.Application.Services
{
    public partial class AuthenticationService() : IAuthenticationService
    {
        public DTOAuthenticationResponse Authenticate(string aCredential)
        {
            // For sure where I would create several rules to proper authentication.
            if (!string.IsNullOrWhiteSpace(aCredential))
                return new(AsymmetricClaimsJwtTokenBuilder([new(JwtRegisteredClaimNames.Name, "Dmytro")]));

            throw new OperationCanceledException("Authentication failed.");
        }

        private static string AsymmetricClaimsJwtTokenBuilder(Claim[] aClaims = null, int? aExpiresIn = null)
        {
            DateTime value = DateTime.UtcNow;
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
            RSA rSA = RSA.Create();
            rSA.ImportRSAPrivateKey(Convert.FromBase64String(Environment.GetEnvironmentVariable("JWT_PRIVATE_KEY")), out var _);

            SecurityToken token = jwtSecurityTokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Subject = (aClaims != null ? new ClaimsIdentity(aClaims) : null),
                Expires = value.AddMinutes(15),
                IssuedAt = value,
                NotBefore = value,
                SigningCredentials = new SigningCredentials(new RsaSecurityKey(rSA), "RS256")
            });
            return jwtSecurityTokenHandler.WriteToken(token);
        }
    }
}
