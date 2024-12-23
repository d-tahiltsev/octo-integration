namespace AlaskaX.Dmytro.Domain.DTOs.Products.Octos
{
    public partial class DTORestrictions
    {
        public static DTORestrictions GetSample()
        {
            return new()
            {
                MinAge = 3,
                MaxAge = 17,
                IdRequired = false,
                MinQuantity = 2,
                MaxQuantity = 7,
                MinUnits = 1,
                MaxUnits = 2,
                PaxCount = 1,
                AccompaniedBy = ["adult_697e3ce8-1860-4cbf-80ad-95857df1f640"]
            };
        }
    }
}
