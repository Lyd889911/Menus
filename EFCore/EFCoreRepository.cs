using Menus.Shared.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFCore
{
    /// <summary>
    /// EF的通用仓储
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public abstract class EFCoreRepository<TDbContext, TEntity, TKey> : EFCoreRepository<TDbContext, TEntity>, IRepository<TEntity, TKey>
        where TDbContext : DbContext
        where TEntity : Entity
    {
        public EFCoreRepository(TDbContext dbContext):base(dbContext)
        {
            
        }
        public Task DeleteAsync(TKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(IEnumerable<TKey> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// EF通用仓储
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class EFCoreRepository<TDbContext, TEntity> : IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : Entity
    {
        protected TDbContext DbContext;
        protected readonly DbSet<TEntity> DbSet;
        public EFCoreRepository(TDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet=dbContext.Set<TEntity>();
        }
        public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(IEnumerable<TEntity> entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> GetQueryAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TResult>> GetQueryAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selector)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateManyAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }

    public class Repository<TDbContext, TEntity> : EFCoreRepository<TDbContext, TEntity>
    where TEntity : Entity
    where TDbContext : DbContext
    {
        public Repository(TDbContext dbContext) : base(dbContext)
        {
        }
    }
}