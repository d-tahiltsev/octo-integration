using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Domain.DTOs.Products.Octos
{
    [Serializable]
    [DataContract]
    public partial class DTORestrictions
    {
        [DataMember]
        [JsonProperty("minUnits")]
        public int MinUnits { get; set; }

        [DataMember]
        [JsonProperty("maxUnits")]
        public int MaxUnits { get; set; }

        [DataMember]
        [JsonProperty("minAge")]
        public int MinAge { get; set; }

        [DataMember]
        [JsonProperty("maxAge")]
        public int MaxAge { get; set; }

        [DataMember]
        [JsonProperty("idRequired")]
        public bool IdRequired { get; set; }

        [DataMember]
        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        [DataMember]
        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }

        [DataMember]
        [JsonProperty("paxCount")]
        public int PaxCount { get; set; }

        [DataMember]
        [JsonProperty("accompaniedBy")]
        public List<string> AccompaniedBy { get; set; } = [];
    }
}
