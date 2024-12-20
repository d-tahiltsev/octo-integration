using AlaskaX.Dmytro.Domain.DTOs.Suppliers;
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
    [Route("octo/supplier")]
    [SwaggerTag("Octo Supplier Controller")]
    [Authorize]
    public class SupplierController(ILogger<ProductsController> logger, ISupplierService supplierService) : ControllerBase
    {
        /// <summary>
        /// Gets Supplier information from Mock data to provide Octo Validation tool proper info
        /// </summary>
        /// <returns>DTO Supplier Response</returns>
        /// <response code="200">Returns supplier info</response>
        /// <response code="400">If there is a bad request or error while finding a product by Id</response>
        /// <response code="404">If no supplier are found</response>
        /// <response code="401">If JWT is not valid</response>
        [HttpGet("", Name = nameof(GetSupplierAsync))]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(DTOSupplierResponse), StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<ActionResult<DTOSupplierResponse>> GetSupplierAsync()
        {
            try
            {
                DTOSupplierResponse dto = await supplierService.LoadAsync();

                if (dto == null)
                    return NotFound();

                return Ok(dto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving supplier info.");

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
