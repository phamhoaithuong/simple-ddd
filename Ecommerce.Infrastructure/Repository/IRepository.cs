using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity item);
        Task<bool> DeleteAsync(object[] keyValues, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(object[] keyValues, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default);
        Task<TEntity> FindAsync(object[] keyValues, CancellationToken cancellationToken = default);
        Task<TEntity> FindAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default);
        void Insert(TEntity item);
        IQueryable<TEntity> Queryable();
        void Update(TEntity item);
    }
}