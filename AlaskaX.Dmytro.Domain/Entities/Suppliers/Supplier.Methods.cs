namespace AlaskaX.Dmytro.Domain.Entities.Suppliers
{
    public partial class Supplier
    {
        public static Supplier GetSample()
        {
            Supplier supplier = new()
            {
                Name = "Dmytro Explore",
                Endpoint = "https://api.dmytro.com/api",
                Contact = Contact.GetSample()
            };

            supplier.Enable();

            return supplier;
        }
    }


}
