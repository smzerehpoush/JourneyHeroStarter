using Net.JourneyHero.Application.BuildingBlocks.CQRS.Commands;
using Net.JourneyHero.Application.Products.Models;

namespace Net.JourneyHero.Application.Products.Commands.AddProduct;

public class AddProductCommandHandler : ICommandHandler<AddProductCommand, ProductViewModel>
{
    public Task<ProductViewModel> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}