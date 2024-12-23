using AlaskaX.Dmytro.Adapter.Octo_Travel;

using Microsoft.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.Annotations;

namespace AlaskaX.Dmytro.RestAPI.Controllers
{
    /// <summary>
    /// API controller responsible for integrating with the Octo Travel Api to retrieve products.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Octo Travel Products Integration Controller")]
    public class OctoTravelsController(ILogger<ProductsController> logger, IOctoTravelApi octoTravel) : ControllerBase
    {
        ///// <summary>
        ///// Gets a list of products from the Octo Travel API.
        ///// </summary>
        ///// <returns>A list of products in the form of DTOProduct objects</returns>
        ///// <response code="200">Returns a list of products</response>
        ///// <response code="400">If there is a bad request or error while fetching products</response>
        ///// <response code="404">If no products are found</response>
        //[HttpGet("Products", Name = nameof(GetOctoTravelProductsAsync))]
        //[HttpHead]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(typeof(IEnumerable<DTOProduct>), StatusCodes.Status200OK)]
        //[Produces("application/problem+json")]
        //[Authorize]
        //public async Task<ActionResult<IEnumerable<DTOProduct>>> GetOctoTravelProductsAsync()
        //{
        //    try
        //    {
        //        return Ok(await octoTravel.GetProductsAsync());
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex, "Error occurred while retrieving products.");

        //        return BadRequest(new ProblemDetails
        //        {
        //            Status = StatusCodes.Status400BadRequest,
        //            Title = "Bad Request",
        //            Detail = ex.Message
        //        });
        //    }
        //}
    }
}
