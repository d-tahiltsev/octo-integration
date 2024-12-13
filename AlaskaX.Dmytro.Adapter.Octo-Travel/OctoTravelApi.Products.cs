using AlaskaX.Dmytro.Adapter.Octo_Travel.DTOs.Products;

using Newtonsoft.Json;

namespace AlaskaX.Dmytro.Adapter.Octo_Travel
{
    public partial class OctoTravelApi
    {
        public async Task<IEnumerable<DTOProduct>> GetProductsAsync()
        {
            HttpRequestMessage httpRequestMessage = new(HttpMethod.Get, OctoTravel.GET_Products);

            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            HttpContent content = httpResponseMessage.Content;

            if (httpResponseMessage.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<IEnumerable<DTOProduct>>(await content.ReadAsStringAsync());

            throw new HttpRequestException(JsonConvert.SerializeObject(httpResponseMessage));
        }
    }
}
