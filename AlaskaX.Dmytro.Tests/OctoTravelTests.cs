using AlaskaX.Dmytro.Octo_Travel;
using AlaskaX.Dmytro.Octo_Travel.DTOs.Products;

namespace AlaskaX.Dmytro.Tests
{
    public class OctoTravelTests
    {
        private readonly IOctoTravelApi octoTravel = new OctoTravelApi();

        [Fact]
        public async Task GetProducts()
        {
            IEnumerable<DTOProduct> products = await octoTravel.GetProductsAsync();

            Assert.True(products.Any());
        }
    }
}