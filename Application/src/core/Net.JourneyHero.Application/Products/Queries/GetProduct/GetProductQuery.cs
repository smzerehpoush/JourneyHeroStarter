using Net.JourneyHero.Application.BuildingBlocks.CQRS.Queries;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Queries.GetProduct;

public class GetProductQuery : IQuery<ProductViewModel>
{
    public GetProductQuery(Guid productId)
    {
        ProductId = productId;
    }

    public Guid ProductId { get; }
}