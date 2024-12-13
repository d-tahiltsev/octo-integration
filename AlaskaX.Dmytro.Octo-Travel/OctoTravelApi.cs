namespace AlaskaX.Dmytro.Octo_Travel
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
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
