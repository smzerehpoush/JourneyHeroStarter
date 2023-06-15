using Microsoft.EntityFrameworkCore;
using Net.JourneyHero.Domain.Products;

namespace Net.JourneyHero.Application.Common.Interfaces
{
    public interface IJourneyHeroDbContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
