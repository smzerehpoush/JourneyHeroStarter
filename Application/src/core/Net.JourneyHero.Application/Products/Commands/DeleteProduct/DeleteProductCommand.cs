using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;

namespace Net.JourneyHero.Application.Products.Commands.DeleteProduct;

public class DeleteProductCommand : ICommand
{
    public DeleteProductCommand(Guid productId)
    {
        ProductId = productId;
    }

    public Guid ProductId { get; }
}