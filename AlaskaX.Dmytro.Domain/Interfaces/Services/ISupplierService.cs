using AlaskaX.Dmytro.Domain.DTOs.Suppliers;

namespace AlaskaX.Dmytro.Domain.Interfaces.Services
{
    public interface ISupplierService
    {
        Task<DTOSupplierResponse> LoadAsync();
    }
}
