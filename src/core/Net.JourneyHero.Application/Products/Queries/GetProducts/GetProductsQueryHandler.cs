using Net.JourneyHero.Application.BuildingBlocks.CQRS.Queries;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Queries.GetProducts;

public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, List<ProductViewModel>>
{
    public Task<List<ProductViewModel>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}