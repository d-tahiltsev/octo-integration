using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Domain.DTOs.Products
{
    [DataContract]
    [Serializable]
    public partial class DTOProductResponse
    {
        /// <summary>
        /// Product Id
        /// </summary>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } = null;

        /// <summary>
        /// Product Name
        /// </summary>
        [DataMember]
        public string Name { get; set; } = string.Empty;


        /// <summary>
        /// Defines if product is enabled
        /// </summary>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; } = false;

        /// <summary>
        /// Defines if product is enabled
        /// </summary>
        [DataMember]
        [DataType(DataType.DateTime)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; } = null;
    }
}
