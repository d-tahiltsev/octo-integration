namespace AlaskaX.Dmytro.Domain.DTOs.Products.Octos
{
    public partial class DTOOption
    {
        public static DTOOption GetSample()
        {
            return new()
            {
                Id = "DEFAULT",
                Default = false,
                InternalName = "Private Morning Tour",
                Reference = "VIP-MORN",
                AvailabilityLocalStartTimes = ["09:00"],
                CancellationCutoff = "1 hour",
                CancellationCutoffAmount = 1,
                CancellationCutoffUnit = "hour",
                RequiredContactFields = ["firstName"],
                Restrictions = DTORestrictions.GetSample(),
                Units = [DTOUnit.GetSample()]
            };
        }
    }
}
