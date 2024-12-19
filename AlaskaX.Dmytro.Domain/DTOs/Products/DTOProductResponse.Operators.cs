using AlaskaX.Dmytro.Domain.Entities.Products;

namespace AlaskaX.Dmytro.Domain.DTOs.Products
{
    /// <summary>
    /// Operators class part
    /// </summary>
    public partial class DTOProductResponse
    {
        /// <summary>
        /// Conversion from Product to Product Response DTO
        /// </summary>
        /// <remarks>
        /// Implicit operator makes conversions easier to reuse to clean code. Also performance increase because this is a native compiled conversion. 
        /// </remarks>
        /// <param name="aProduct">Product Object</param>
        public static implicit operator DTOProductResponse(Product aProduct)
        {
            if (aProduct == null)
                return null;

            return new()
            {
                Id = aProduct.Guid.Value,
                Name = aProduct.Name,
                IsEnabled = aProduct.IsEnabled,
                CreatedAt = aProduct.CreatedAt
            };
        }
    }
}
