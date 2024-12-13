using System.Net.Http.Headers;

namespace AlaskaX.Dmytro.Adapter.Octo_Travel
{
    public partial class OctoTravelApi
    {
        private readonly HttpClient httpClient = new()
        {
            BaseAddress = new Uri(OctoTravel.BaseUrl)
        };

        public OctoTravelApi()
        {
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", OctoTravel.Api_Key);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable(EnvVariable_Api_Key));
        }

        private bool _DisposedValue;
        private const string EnvVariable_Api_Key = "OCTO_TRAVEL_API_KEY";
    }
}
