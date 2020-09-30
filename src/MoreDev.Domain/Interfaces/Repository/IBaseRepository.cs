using System;
using System.Threading;
using System.Threading.Tasks;

namespace MoreDev.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken ct);
        Task<TEntity> GetByIdAsync(object id, CancellationToken ct);
        Task<int> RemoveAsync(TEntity entity, CancellationToken ct);
        Task<bool> RemoveAsync(object id, CancellationToken ct);
    }
}
