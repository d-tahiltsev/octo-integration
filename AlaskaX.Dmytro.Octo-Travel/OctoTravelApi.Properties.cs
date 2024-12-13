using System.Net.Http.Headers;

namespace AlaskaX.Dmytro.Octo_Travel
{
    public partial class OctoTravelApi
    {
        private readonly HttpClient httpClient = new()
        {
            BaseAddress = new Uri(OctoTravel.BaseUrl)
        };

        public OctoTravelApi()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", OctoTravel.Api_Key);
        }

        private bool _DisposedValue;
    }
}
