namespace AlaskaX.Dmytro.Domain.DTOs.Products.Octos
{
    public partial class DTOOctoProductResponse
    {
        public static IEnumerable<DTOOctoProductResponse> GetSamples()
            => [GetSampleA(), GetSampleB()];

        public static DTOOctoProductResponse GetSampleA()
        {
            return new()
            {
                Id = Guid.NewGuid(),
                AllowFreesale = true,
                AvailabilityRequired = true,
                AvailabilityType = "OPENING_HOURS",
                InstantConfirmation = false,
                InstantDelivery = false,
                InternalName = "Amazon River Tour",
                Locale = "en-GB",
                RedemptionMethod = "DIGITAL",
                Reference = "AMZN",
                TimeZone = "Europe/London",
                DeliveryFormats = ["QRCODE"],
                DeliveryMethods = ["VOUCHER"],
                Options = [DTOOption.GetSample()]
            };
        }

        public static DTOOctoProductResponse GetSampleB()
        {
            return new()
            {
                Id = Guid.NewGuid(),
                AllowFreesale = true,
                AvailabilityRequired = true,
                AvailabilityType = "START_TIME",
                InstantConfirmation = false,
                InstantDelivery = false,
                InternalName = "Amazon River Tour",
                Locale = "en-GB",
                RedemptionMethod = "DIGITAL",
                Reference = "AMZN",
                TimeZone = "Europe/London",
                DeliveryFormats = ["QRCODE"],
                DeliveryMethods = ["VOUCHER"],
                Options = [DTOOption.GetSample()]
            };
        }
    }
}
