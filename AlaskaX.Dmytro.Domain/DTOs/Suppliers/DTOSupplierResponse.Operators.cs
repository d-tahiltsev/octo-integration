using AlaskaX.Dmytro.Domain.Entities.Suppliers;

namespace AlaskaX.Dmytro.Domain.DTOs.Suppliers
{
    /// <summary>
    /// Operators class part
    /// </summary>
    public partial class DTOSupplierResponse
    {
        /// <summary>
        /// Conversion from Supplier to Supplier Response DTO
        /// </summary>
        /// <remarks>
        /// Implicit operator makes conversions easier to reuse to clean code. Also performance increase because this is a native compiled conversion. 
        /// </remarks>
        /// <param name="aSupplier">Supplier Object</param>
        public static implicit operator DTOSupplierResponse(Supplier aSupplier)
        {
            if (aSupplier == null)
                return null;

            return new()
            {
                Id = aSupplier.Guid.Value,
                Name = aSupplier.Name,
                Endpoint = aSupplier.Endpoint,
                DtoContact = aSupplier.Contact
            };
        }
    }
}
