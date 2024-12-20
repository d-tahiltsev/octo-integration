using AlaskaX.Dmytro.Application.Services.DTOs.Authentication;
using AlaskaX.Dmytro.Domain.Interfaces.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.Annotations;

namespace AlaskaX.Dmytro.RestAPI.Controllers
{
    /// <summary>
    /// API controller responsible for integrating with the Octo Travel Api to retrieve products.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Authentication Controller")]
    [Authorize]
    public class AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authenticationService) : ControllerBase
    {
        /// <summary>
        /// Method available provide API authentication using provided Credential.
        /// </summary>
        /// <remarks>
        /// Place your credential hash on this request header.
        /// Use any string because it's a test API. Any non-blank string should authorizer you. :)</remarks>
        /// <param name="credentials">Credentials Token</param>
        /// <response code="400">Bad request: Invalid token</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="200">Ok</response>
        [HttpGet("", Name = nameof(GetAuthentication))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(DTOAuthenticationResponse), StatusCodes.Status200OK)]
        [Produces("application/problem+json")]
        [AllowAnonymous]
        public ActionResult<DTOAuthenticationResponse> GetAuthentication([FromHeader] string credentials)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(credentials))
                    return BadRequest(nameof(credentials));

                return Ok(authenticationService.Authenticate(credentials));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while authenticating.");

                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = ex.Message
                });
            }
        }
    }
}
