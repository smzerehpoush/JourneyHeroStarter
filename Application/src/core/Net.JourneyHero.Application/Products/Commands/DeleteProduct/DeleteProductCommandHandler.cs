using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;

namespace Net.JourneyHero.Application.Products.Commands.DeleteProduct;

public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand>
{
    public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}