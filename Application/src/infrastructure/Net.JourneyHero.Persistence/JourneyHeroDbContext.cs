using Microsoft.EntityFrameworkCore;
using Net.JourneyHero.Application.Common.Interfaces;
using Net.JourneyHero.Domain.Common.Entities;
using Net.JourneyHero.Domain.Products;

namespace Net.JourneyHero.Persistence
{
    public class JourneyHeroDbContext : DbContext, IJourneyHeroDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public JourneyHeroDbContext(DbContextOptions<JourneyHeroDbContext> options)
            : base(options)
        {
        }

        public JourneyHeroDbContext(
            DbContextOptions<JourneyHeroDbContext> options,
            ICurrentUserService currentUserService)
            : base(options)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<Product> Products { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JourneyHeroDbContext).Assembly);
        }
    }
}