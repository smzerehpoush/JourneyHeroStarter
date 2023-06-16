using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net.JourneyHero.WebApi.Controllers;

public class BaseController : ControllerBase
{
    private IMediator _mediator = null!;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
}