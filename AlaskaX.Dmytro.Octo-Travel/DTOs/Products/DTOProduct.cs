using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace AlaskaX.Dmytro.Octo_Travel.DTOs.Products
{
    [Serializable]
    [DataContract]
    public partial class DTOProduct
    {
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        [DataMember]
        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [DataMember]
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [DataMember]
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [DataMember]
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [DataMember]
        [JsonProperty("allowFreesale")]
        public bool AllowFreesale { get; set; }

        [DataMember]
        [JsonProperty("instantConfirmation")]
        public bool InstantConfirmation { get; set; }

        [DataMember]
        [JsonProperty("instantDelivery")]
        public bool InstantDelivery { get; set; }

        [DataMember]
        [JsonProperty("availabilityRequired")]
        public bool AvailabilityRequired { get; set; }

        [DataMember]
        [JsonProperty("availabilityType")]
        public string AvailabilityType { get; set; }

        [DataMember]
        [JsonProperty("deliveryFormats")]
        public List<string> DeliveryFormats { get; set; }

        [DataMember]
        [JsonProperty("deliveryMethods")]
        public List<string> DeliveryMethods { get; set; }

        [DataMember]
        [JsonProperty("redemptionMethod")]
        public string RedemptionMethod { get; set; }

        [DataMember]
        [JsonProperty("options")]
        public List<DTOOption> Options { get; set; }
    }
}
