using AlaskaX.Dmytro.Domain.Entities.Products;

namespace AlaskaX.Dmytro.Domain.DTOs.Products
{
    public partial class DTOProductUpdate
    {
        public DTOProductUpdate()
        {
        }

        public DTOProductUpdate SetId(Guid aId)
        {
            Id = aId;
            return this;
        }

        public Guid GetId() => Id;

        public Product To(Product aOriginalProduct)
        {
            aOriginalProduct.SetName(Name);

            if (IsEnabled)
                aOriginalProduct.Enable();
            else
                aOriginalProduct.Disable();

            return aOriginalProduct;
        }
    }
}
