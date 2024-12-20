using AlaskaX.Dmytro.Domain.DTOs.Suppliers;
using AlaskaX.Dmytro.Domain.Entities.Suppliers;
using AlaskaX.Dmytro.Domain.Interfaces.Services;

namespace AlaskaX.Dmytro.Application.Services
{
    public partial class SupplierService : ISupplierService
    {
        public async Task<DTOSupplierResponse> LoadAsync()
            => Supplier.GetSample();
    }
}
