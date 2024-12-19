using AlaskaX.Dmytro.Domain.Entities.Products;

namespace AlaskaX.Dmytro.Domain.DTOs.Products
{
    /// <summary>
    /// Operators class part
    /// </summary>
    public partial class DTOProductInsert
    {
        /// <summary>
        /// Conversion from Product Insert DTO to Product entity class
        /// </summary>
        /// <remarks>
        /// Implicit operator makes conversions easier to reuse to clean code. Also performance increase because this is a native compiled conversion. 
        /// </remarks>
        /// <param name="aDto">Product insert DTO</param>
        public static implicit operator Product(DTOProductInsert aDto)
        {
            if (aDto == null)
                return null;

            Product product = new();

            if (aDto.IsEnabled)
                product.Enable();
            else
                product.Disable();

            return product.SetName(aDto.Name);
        }
    }
}
