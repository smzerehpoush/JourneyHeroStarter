using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.UpdateProduct;

public class UpdateProductCommand : ICommand<ProductViewModel>
{
    public UpdateProductCommand(Guid productId)
    {
        ProductId = productId;
    }

    public Guid ProductId { get; }
}