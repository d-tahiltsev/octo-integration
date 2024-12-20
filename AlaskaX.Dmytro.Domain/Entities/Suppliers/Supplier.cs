namespace AlaskaX.Dmytro.Domain.Entities.Suppliers
{
    public partial class Supplier(bool aAutoIdentity = true) : EntityBase(aAutoIdentity)
    {
        public string Name { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public Contact Contact { get; set; } = new();
    }


}
