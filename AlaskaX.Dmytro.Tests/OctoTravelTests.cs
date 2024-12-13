using AlaskaX.Dmytro.Adapter.Octo_Travel;
using AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products;

namespace AlaskaX.Dmytro.Tests
{
    public class OctoTravelTests
    {
        private readonly OctoTravelApi octoTravel = new();

        [Fact]
        public async Task GetProducts()
        {
            IEnumerable<DTOProduct> products = await octoTravel.GetProductsAsync();

            Assert.True(products.Any());
        }
    }
}