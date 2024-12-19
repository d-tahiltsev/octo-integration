using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Domain.DTOs.Products
{
    [DataContract]
    [Serializable]
    public partial class DTOProductInsert
    {
        /// <summary>
        /// Product Name
        /// </summary>
        [DataMember]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(100, ErrorMessage = "{0} has a limit of 100 characters.")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Defines if product is enabled
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; } = false;
    }
}
