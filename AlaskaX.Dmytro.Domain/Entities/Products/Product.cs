using System.ComponentModel.DataAnnotations;

namespace AlaskaX.Dmytro.Domain.Entities.Products
{
    public partial class Product(bool aAutoIdentity = true) : EntityBase(aAutoIdentity)
    {
        /// <summary>
        /// Product Name
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} has a limit of 100 characters.")]
        public string Name { get; private set; } = string.Empty;
    }
}
