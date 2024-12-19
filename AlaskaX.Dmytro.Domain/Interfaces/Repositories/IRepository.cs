using AlaskaX.Dmytro.Domain.Entities;

namespace AlaskaX.Dmytro.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Generic basic repository interface
    /// </summary>
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        #region [ Read ]



        #endregion


        #region [ Write ]



        #endregion
    }
}
