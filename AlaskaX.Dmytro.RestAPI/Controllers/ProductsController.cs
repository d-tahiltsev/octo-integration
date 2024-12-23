using AlaskaX.Dmytro.Domain.DTOs.Products;
using AlaskaX.Dmytro.Domain.DTOs.Products.Octos;
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
    [SwaggerTag("Local products Controller for Octo Travel integration")]
    [Authorize]
    public class ProductsController(ILogger<ProductsController> logger, IProductService productService) : ControllerBase
    {
        /// <summary>
        /// Gets Products information from Mock data to provide Octo Validation tool proper info
        /// </summary>
        /// <returns>DTO OctoProducts Response</returns>
        /// <response code="200">Returns products info</response>
        /// <response code="404">If no products are found</response>
        /// <response code="401">If JWT is not valid</response>
        [HttpGet("~/octo/products", Name = nameof(GetOctoProductsAsync))]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(IEnumerable<DTOOctoProductResponse>), StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<DTOOctoProductResponse>>> GetOctoProductsAsync()
        {
            try
            {
                IEnumerable<DTOOctoProductResponse> dtos = DTOOctoProductResponse.GetSamples();

                if (dtos == null)
                    return NotFound();

                return Ok(dtos);
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

        /// <summary>
        /// Gets a product from database by Id
        /// </summary>
        /// <returns>DTO Product Response</returns>
        /// <response code="200">Returns a list of products</response>
        /// <response code="400">If there is a bad request or error while finding a product by Id</response>
        /// <response code="404">If no products are found</response>
        [HttpGet("{aId:guid}", Name = nameof(GetProductAsync))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(DTOProductResponse), StatusCodes.Status200OK)]
        [Produces("application/problem+json")]
        public async Task<ActionResult<DTOProductResponse>> GetProductAsync([FromRoute] Guid aId)
        {
            try
            {
                DTOProductResponse dto = await productService.LoadAsync(aId);

                if (dto == null)
                    return NotFound();

                return Ok(dto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving a product.");

                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = ex.Message
                });
            }
        }

        /// <summary>
        /// Gets all products from database
        /// </summary>
        /// <returns>A list of products DTO Response</returns>
        /// <response code="200">Returns a list of products</response>
        /// <response code="400">If there is a bad request or error while fetching products</response>
        [HttpGet("", Name = nameof(GetProductsAsync))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(IEnumerable<DTOProductResponse>), StatusCodes.Status200OK)]
        [Produces("application/problem+json")]
        public async Task<ActionResult<IEnumerable<DTOProductResponse>>> GetProductsAsync()
        {
            try
            {
                return Ok(await productService.ListAsync());
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving products.");

                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = ex.Message
                });
            }
        }

        /// <summary>
        /// Creates a product in database
        /// </summary>
        /// <returns>Product created</returns>
        /// <response code="200">Created product</response>
        /// <response code="400">Error occurred while creating a product</response>
        [HttpPost("", Name = nameof(PostProductsAsync))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(DTOProductResponse), StatusCodes.Status200OK)]
        [Produces("application/problem+json")]
        [Consumes("application/json")]
        public async Task<ActionResult<DTOProductResponse>> PostProductsAsync([FromBody] DTOProductInsert aDtoInsert)
        {
            try
            {
                DTOProductResponse dto = await productService.CreateAsync(aDtoInsert);
                return CreatedAtRoute(nameof(GetProductAsync), new
                {
                    aId = dto.Id
                }, dto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while creating a product.");

                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = ex.Message
                });
            }
        }

        /// <summary>
        /// Update product information
        /// </summary>
        /// <returns>DTO Product Response</returns>
        /// <response code="200">Returns updated product</response>
        /// <response code="400">Error occurred while updating a product</response>
        [HttpPut("{aId:guid}", Name = nameof(PutProductsAsync))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(DTOProductResponse), StatusCodes.Status200OK)]
        [Produces("application/problem+json")]
        [Consumes("application/json")]
        public async Task<ActionResult<DTOProductResponse>> PutProductsAsync([FromRoute] Guid aId, [FromBody] DTOProductUpdate aDtoUpdate)
        {
            try
            {
                DTOProductResponse dto = await productService.UpdateAsync(aDtoUpdate.SetId(aId));
                return Ok(dto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while updating a product.");

                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = ex.Message
                });
            }
        }

        /// <summary>
        /// Deletes a product by Id.
        /// </summary>
        /// <param name="aId">Product Id.</param>
        /// <returns>Deletion confirmation.</returns>
        [HttpDelete("{aId:guid}", Name = nameof(DeleteProductAsync))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteProductAsync([FromRoute] Guid aId)
        {
            try
            {
                await productService.DeleteAsync(aId);
                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while deleting a product.");

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
