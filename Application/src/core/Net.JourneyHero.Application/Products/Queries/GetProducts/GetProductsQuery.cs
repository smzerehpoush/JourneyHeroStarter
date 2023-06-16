using Net.JourneyHero.Application.BuildingBlocks.CQRS.Queries;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Queries.GetProducts;

public class GetProductsQuery : IQuery<List<ProductViewModel>>
{
}