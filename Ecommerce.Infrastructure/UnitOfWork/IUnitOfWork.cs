using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}