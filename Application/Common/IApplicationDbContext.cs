using DataModels;
using Microsoft.EntityFrameworkCore;

namespace Application.Common
{
    public interface IApplicationDbContext
    {
        DbSet<Investment> Investments { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
