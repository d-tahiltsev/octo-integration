namespace AlaskaX.Dmytro.Domain.DTOs.Products.Octos
{
    public partial class DTOUnit
    {
        public static DTOUnit GetSample()
        {
            return new()
            {
                Id = Guid.NewGuid(),
                InternalName = "Adult(s)",
                Reference = "LR1-01-new",
                RequiredContactFields = ["firstName"],
                Restrictions = DTORestrictions.GetSample(),
                Type = "YOUTH"
            };
        }
    }

}
