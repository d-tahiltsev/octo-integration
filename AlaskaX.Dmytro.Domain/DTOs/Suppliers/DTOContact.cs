using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Domain.DTOs.Suppliers
{
    [Serializable]
    [DataContract]
    public partial class DTOContact
    {
        [DataMember]
        [DataType(DataType.Url)]
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; } = string.Empty;

        [DataMember]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; } = string.Empty;

        [DataMember]
        [JsonProperty("telephone", NullValueHandling = NullValueHandling.Ignore)]
        public string Telephone { get; set; } = string.Empty;

        [DataMember]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; } = string.Empty;
    }
}
