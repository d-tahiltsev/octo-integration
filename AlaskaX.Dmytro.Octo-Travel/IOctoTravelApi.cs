using AlaskaX.Dmytro.Octo_Travel.DTOs.Products;

namespace AlaskaX.Dmytro.Octo_Travel
{
    public interface IOctoTravelApi : IDisposable
    {
        Task<IEnumerable<DTOProduct>> GetProductsAsync();
    }
}
