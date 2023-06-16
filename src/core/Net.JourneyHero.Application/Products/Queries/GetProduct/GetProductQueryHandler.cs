using Net.JourneyHero.Application.BuildingBlocks.CQRS.Queries;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Queries.GetProduct;

public class GetProductQueryHandler : IQueryHandler<GetProductQuery, ProductViewModel>
{
    public Task<ProductViewModel> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}