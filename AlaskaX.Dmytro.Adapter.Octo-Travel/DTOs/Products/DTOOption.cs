using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products
{
    [Serializable]
    [DataContract]
    public class DTOOption
    {
        [DataMember]
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [DataMember]
        [JsonProperty("default")]
        public bool Default { get; set; }

        [DataMember]
        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [DataMember]
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [DataMember]
        [JsonProperty("availabilityLocalStartTimes")]
        public List<string> AvailabilityLocalStartTimes { get; set; } = [];

        [DataMember]
        [JsonProperty("cancellationCutoff")]
        public string CancellationCutoff { get; set; }

        [DataMember]
        [JsonProperty("cancellationCutoffAmount")]
        public int CancellationCutoffAmount { get; set; }

        [DataMember]
        [JsonProperty("cancellationCutoffUnit")]
        public string CancellationCutoffUnit { get; set; }

        [DataMember]
        [JsonProperty("requiredContactFields")]
        public List<string> RequiredContactFields { get; set; } = [];

        [DataMember]
        [JsonProperty("restrictions")]
        public DTORestrictions Restrictions { get; set; } = new();

        [DataMember]
        [JsonProperty("units")]
        public List<DTOUnit> Units { get; set; } = [];
    }
}
