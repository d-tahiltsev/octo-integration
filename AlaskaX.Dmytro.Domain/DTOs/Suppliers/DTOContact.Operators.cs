using AlaskaX.Dmytro.Domain.Entities.Suppliers;

namespace AlaskaX.Dmytro.Domain.DTOs.Suppliers
{
    /// <summary>
    /// Operators class part
    /// </summary>
    public partial class DTOContact
    {
        /// <summary>
        /// Conversion from Contact to Contact Response DTO
        /// </summary>
        /// <remarks>
        /// Implicit operator makes conversions easier to reuse to clean code. Also performance increase because this is a native compiled conversion. 
        /// </remarks>
        /// <param name="aContact">Contact Object</param>
        public static implicit operator DTOContact(Contact aContact)
        {
            if (aContact == null)
                return null;

            return new()
            {
                Address = aContact.Address,
                Email = aContact.Email,
                Telephone = aContact.Telephone,
                Website = aContact.Website
            };
        }
    }
}
