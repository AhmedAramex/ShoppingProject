using CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controllers;

public class ProductControllers : BaseController
{
    private readonly IMediator _mediator;

    public ProductControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetProducts")]
    public async Task<IActionResult> GetProducts()
    {
        var Products = await _mediator.Send(new GetProductRequest());

        return Ok(Products);
    }
}
