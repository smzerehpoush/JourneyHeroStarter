using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ProductViewModel>
{
    public Task<ProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}