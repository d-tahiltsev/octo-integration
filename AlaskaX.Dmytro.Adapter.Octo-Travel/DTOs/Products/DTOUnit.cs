using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products
{
    [Serializable]
    [DataContract]
    public class DTOUnit
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("requiredContactFields")]
        public List<string> RequiredContactFields { get; set; } = [];

        [JsonProperty("restrictions")]
        public DTORestrictions Restrictions { get; set; } = new();
    }

}
