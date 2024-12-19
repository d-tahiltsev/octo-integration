using AlaskaX.Dmytro.Domain.Entities;
using AlaskaX.Dmytro.Domain.Interfaces.Repositories;

namespace AlaskaX.Dmytro.Infrastructure.Data.Contexts
{
    /// <summary>
    /// MySQL Repository
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="aMySQL">Injected Context</param>
    public partial class MySQLRepository<T>(MySQL aMySQL) : IRepository<T> where T : EntityBase
    {

        /// <summary>
        /// Gets current session
        /// </summary>
        /// <returns>MySQL context</returns>
        public MySQL GetDBSession()
        {
            return aMySQL;
        }

        #region [ Dispose Pattern ]

        private readonly bool _disposed;

        ~MySQLRepository() => ((IDisposable)this).Dispose();

        void IDisposable.Dispose()
        {
            if (!_disposed)
                aMySQL.Dispose();
            GC.SuppressFinalize(this);
        }

        public Task<T> LoadAsync(int aId)
        {
            throw new NotImplementedException();
        }

        public Task<T> LoadAsync(Guid aId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
