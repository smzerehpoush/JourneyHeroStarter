using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, ProductViewModel>
{
    public Task<ProductViewModel> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}