using CleanArchitectureCQRs.Application.Features.Products.Commands;
using CleanArchitectureCQRs.Application.Features.Products.Queries;
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

    [HttpGet("Product/{ProductId}")]
    public async Task<IActionResult> GetProductAsync(Guid ProductId)
    {
        try
        {
            var result = await _mediator.Send(new GetProductByIdQuery(ProductId));
            if (result is null) return BadRequest("Product is not found!");
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("by-category/{categoryId}")]
    public async Task<IActionResult> GetProductByCategoryIdAsync(Guid categoryId)
    {
        try
        {
            var result = await _mediator.Send(new GetProductsByCategory(categoryId));
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
