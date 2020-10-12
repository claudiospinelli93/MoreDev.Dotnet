using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoreDev.Domain.Interfaces.Repository;
using MoreDev.Infra.Data.SqlServer.Context;

namespace MoreDev.Infra.Data.SqlServer.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly MoreDevContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(MoreDevContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken ct)
        {
            var result = await DbSet.AddAsync(entity, ct);
            await CommitAsync(ct);
            return result.Entity;
        }

        public async Task<TEntity> GetByIdAsync(object id, CancellationToken ct)
        {
            return await DbSet.FindAsync(id, ct);
        }

        public async Task<int> RemoveAsync(TEntity entity, CancellationToken ct)
        {
            DbSet.Remove(entity);
            return await CommitAsync(ct);
        }
        public async Task<bool> RemoveAsync(object id, CancellationToken ct)
        {
            TEntity entity = await GetByIdAsync(id, ct);

            if (entity == null) return false;

            return await RemoveAsync(entity, ct) > 0;
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        private async Task<int> CommitAsync(CancellationToken ct)
        {
            return await Context.SaveChangesAsync(ct);
        }
    }
}
