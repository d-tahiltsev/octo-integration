namespace AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products
{
    public partial class DTOProduct
    {
        public static IEnumerable<DTOProduct> GetSamples()
            => [GetSample()];

        public static DTOProduct GetSample()
        {
            return new()
            {
                Id = Guid.NewGuid(),
                AllowFreesale = true,
                AvailabilityRequired = true,
                AvailabilityType = "",
                InstantConfirmation = false,
                InstantDelivery = false,
                InternalName = "Dmytro",
                Locale = "en-US",
                RedemptionMethod = "",
                Reference = "",
                TimeZone = ""
            };
        }
    }
}
