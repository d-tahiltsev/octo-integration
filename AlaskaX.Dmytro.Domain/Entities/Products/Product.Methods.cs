namespace AlaskaX.Dmytro.Domain.Entities.Products
{
    public partial class Product
    {
        public Product SetName(string aName)
        {
            aName = aName.Trim();

            if (string.IsNullOrEmpty(aName))
                throw new ArgumentNullException("Name cannot be blank.");

            Name = aName;

            return this;
        }

    }
}
