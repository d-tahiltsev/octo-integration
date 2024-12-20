namespace AlaskaX.Dmytro.Domain.Entities.Suppliers
{
    public partial class Contact
    {
        public static Contact GetSample()
            => new()
            {
                Address = "1254 Dmytro street",
                Telephone = "+380 45 123 4567",
                Email = "dmytro@dmytro.dev",
                Website = "https://dmytro.dev"
            };
    }


}
