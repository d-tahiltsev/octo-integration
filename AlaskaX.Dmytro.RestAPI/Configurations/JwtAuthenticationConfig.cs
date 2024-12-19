using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

using System.Security.Cryptography;

namespace AlaskaX.Dmytro.RestAPI.Configurations
{
    public static class JwtAuthenticationConfig
    {
        /// <summary>
        /// JWT Auth service configuration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddJwtAuthenticationConfig(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(
                Convert.FromBase64String(Environment.GetEnvironmentVariable("JWT_PUBLIC_KEY")),
                out var _
            );

            RsaSecurityKey securityKey = new(rsa);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(
                    jwtconfig =>
                    {
                        jwtconfig.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = false,
                            ClockSkew = new TimeSpan(DateTime.UtcNow.Ticks),
                            IssuerSigningKey = securityKey,
                            RequireExpirationTime = true,
                            LifetimeValidator = (notBefore, expires, securityToken, _) => notBefore <= DateTime.UtcNow && expires >= DateTime.UtcNow
                        };
                    });
        }
    }
}