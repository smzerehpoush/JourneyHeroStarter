using Microsoft.EntityFrameworkCore;

namespace Net.JourneyHero.Persistence
{
    public class JourneyHeroDbContextFactory : DesignTimeDbContextFactoryBase<JourneyHeroDbContext>
    {
        protected override JourneyHeroDbContext CreateNewInstance(DbContextOptions<JourneyHeroDbContext> options)
        {
            return new JourneyHeroDbContext(options);
        }
    }
}