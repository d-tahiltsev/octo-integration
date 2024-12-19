using AlaskaX.Dmytro.Domain.DTOs.Products;

namespace AlaskaX.Dmytro.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<DTOProductResponse> LoadAsync(Guid aId);
        Task<IEnumerable<DTOProductResponse>> ListAsync();
        Task<DTOProductResponse> CreateAsync(DTOProductInsert aDtoInsert);
        Task<DTOProductResponse> UpdateAsync(DTOProductUpdate aDtoUpdate);
        Task DeleteAsync(Guid aId);
    }
}
