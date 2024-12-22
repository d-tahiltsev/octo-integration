

using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Domain.DTOs.Suppliers
{
    [Serializable]
    [DataContract]
    public partial class DTOSupplierResponse
    {
        [DataMember]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [DataMember]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [DataMember]
        [DataType(DataType.Url)]
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; } = string.Empty;

        [DataMember]
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public DTOContact DtoContact { get; set; } = new();
    }


}
