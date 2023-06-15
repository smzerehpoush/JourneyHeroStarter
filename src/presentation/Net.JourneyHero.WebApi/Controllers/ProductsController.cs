using Microsoft.AspNetCore.Mvc;
using Net.JourneyHero.Application.Products.Models;
using Net.JourneyHero.Application.Products.Queries.GetProducts;

namespace Net.JourneyHero.WebApi.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductsController : BaseController
{
    [HttpGet]
    public async Task<List<ProductViewModel>> GetProducts()
    {
        var query = new GetProductsQuery();
        return await Mediator.Send(query);
    }
}