using Microsoft.EntityFrameworkCore;
using Net.JourneyHero.Application.Common.Interfaces;
using Net.JourneyHero.Domain.Products;
using Net.JourneyHero.Domain.Products.Exceptions;

namespace Net.JourneyHero.Persistence.Repositories;

public class ProductsRepository : IProductsRepository
{
    private readonly IJourneyHeroDbContext _dbContext;

    public ProductsRepository(IJourneyHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Product> Add(Product entity, CancellationToken cancellationToken)
    {
        var savedEntity = await _dbContext.Products.AddAsync(entity, cancellationToken);
        return savedEntity.Entity;
    }

    public Task<List<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return _dbContext.Products.ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Products.Where(p => p.Id.Equals(id))
                   .FirstOrDefaultAsync(cancellationToken: cancellationToken) ??
               throw new ProductNotFoundException();
    }

    public async Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity = await GetByIdAsync(id, cancellationToken);
        _dbContext.Products.Remove(entity);
    }
}