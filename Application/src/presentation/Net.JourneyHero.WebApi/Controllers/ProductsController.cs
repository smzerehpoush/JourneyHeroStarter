using Microsoft.AspNetCore.Mvc;
using Net.JourneyHero.Application.Common.Models;
using Net.JourneyHero.Application.Products.Commands.CreateProduct;
using Net.JourneyHero.Application.Products.Commands.DeleteProduct;
using Net.JourneyHero.Application.Products.Commands.UpdateProduct;
using Net.JourneyHero.Application.Products.Models;
using Net.JourneyHero.Application.Products.Queries.GetProduct;
using Net.JourneyHero.Application.Products.Queries.GetProducts;

namespace Net.JourneyHero.WebApi.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductsController : BaseController
{
    [HttpPost]
    public async Task<Result<ProductViewModel>> GetProducts(CreateProductCommand command)
    {
        var commandResult = await Mediator.Send(command);
        return Result<ProductViewModel>.Succeed(commandResult);
    }

    [HttpGet]
    public async Task<Result<List<ProductViewModel>>> GetProducts()
    {
        var query = new GetProductsQuery();
        var queryResult = await Mediator.Send(query);
        return Result<List<ProductViewModel>>.Succeed(queryResult);
    }

    [HttpGet("/{id:guid}")]
    public async Task<Result<ProductViewModel>> GetProduct(Guid id)
    {
        var query = new GetProductQuery(id);
        var queryResult = await Mediator.Send(query);
        return Result<ProductViewModel>.Succeed(queryResult);
    }


    [HttpPut("/{id:guid}")]
    public async Task<Result<ProductViewModel>> UpdateProduct(Guid id)
    {
        var command = new UpdateProductCommand(id);
        var commandResult = await Mediator.Send(command);
        return Result<ProductViewModel>.Succeed(commandResult);
    }

    [HttpDelete("/{id:guid}")]
    public async Task<Result<object>> DeleteProduct(Guid id)
    {
        var command = new DeleteProductCommand(id);
        await Mediator.Send(command);
        return Result<ProductViewModel>.Succeed();
    }
}