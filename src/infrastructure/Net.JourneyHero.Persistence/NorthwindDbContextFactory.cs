using Microsoft.EntityFrameworkCore;
using Net.JourneyHero.Persistence;

namespace Northwind.Persistence
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<JourneyHeroDbContext>
    {
        protected override JourneyHeroDbContext CreateNewInstance(DbContextOptions<JourneyHeroDbContext> options)
        {
            return new JourneyHeroDbContext(options);
        }
    }
}
