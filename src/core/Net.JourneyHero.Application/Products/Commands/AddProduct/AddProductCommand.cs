using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.AddProduct;

public class AddProductCommand : ICommand<ProductViewModel>
{
}