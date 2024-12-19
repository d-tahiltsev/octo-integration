using AlaskaX.Dmytro.Domain.DTOs.Products;
using AlaskaX.Dmytro.Domain.Entities.Products;
using AlaskaX.Dmytro.Domain.Interfaces.Services;

namespace AlaskaX.Dmytro.Application.Services
{
    public partial class ProductService : IProductService
    {
        public async Task<DTOProductResponse> LoadAsync(Guid aId)
        {
            return await GetProductAsync(aId);
        }

        public async Task<IEnumerable<DTOProductResponse>> ListAsync()
        {
            IEnumerable<Product> products = []; // Fetches all products from database. Of course here, I would get only enabled products. Or it should have fiters and paging.

            return products.Select(p => (DTOProductResponse)p);
        }

        public async Task<DTOProductResponse> CreateAsync(DTOProductInsert aDtoInsert)
        {
            Product product = aDtoInsert;

            // Creates product on repository;

            return product;
        }


        public async Task<DTOProductResponse> UpdateAsync(DTOProductUpdate aDtoUpdate)
        {
            Product product = await GetProductAsync(aDtoUpdate.GetId());

            product = aDtoUpdate.To(product); // Saves updated product on repository

            return product;
        }

        public async Task DeleteAsync(Guid aId)
        {
            Product product = await GetProductAsync(aId);

            // Delete product on repository

            return;
        }

        #region [ Private ]

        private async Task<Product> GetProductAsync(Guid aId)
        {
            Product product = new(); //Get from repository database

            return product;
        }

        #endregion
    }
}
