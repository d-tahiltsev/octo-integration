using AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products;

namespace AlaskaX.Dmytro.Adapter.Octo_Travel
{
    public interface IOctoTravelApi : IDisposable
    {
        Task<IEnumerable<DTOProduct>> GetProductsAsync();
    }
}
