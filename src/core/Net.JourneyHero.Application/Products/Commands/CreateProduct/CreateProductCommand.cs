using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.CreateProduct;

public class CreateProductCommand : ICommand<ProductViewModel>
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string? Description { get; set; }
}