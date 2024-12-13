namespace AlaskaX.Dmytro.Adapter.Octo_Travel
{
    public partial class OctoTravelApi : IOctoTravelApi
    {
        protected virtual void Dispose(bool disposing)
        {
            if (!_DisposedValue)
            {
                if (disposing)
                {
                    httpClient.Dispose();
                }
                _DisposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
