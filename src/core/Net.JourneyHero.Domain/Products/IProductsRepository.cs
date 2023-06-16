namespace Net.JourneyHero.Domain.Products;

public interface IProductsRepository
{
    Task<Product> Add(Product entity, CancellationToken cancellationToken);
    Task<List<Product>> GetAllAsync(CancellationToken cancellationToken);

    Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
}