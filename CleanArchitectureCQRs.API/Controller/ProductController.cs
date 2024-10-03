using CleanArchitectureCQRs.Application.Products.Commands;
using CleanArchitectureCQRs.Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controller;

public class ProductController : BaseController
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> AddProductAsync(CreateProductCommand productDto)
    {
        var result = await _mediator.Send(productDto);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetProductAsync(Guid id)
    {
        try
        {
            var result = await _mediator.Send(new GetProductQuery(id));
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
