using CleanArchitectureCQRs.Application.Features.Categories.Queries;
using CleanArchitectureCQRs.Application.Features.Products.Commands;
using CleanArchitectureCQRs.Application.Features.Products.Queries;
using CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    public async Task<IActionResult> GetProductByIdAsync(Guid ProductId)
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

    [Authorize]
    [HttpGet("Products")]
    public async Task<IActionResult> GetAllProductsAsync()
    {
        try 
        {
            var result = await _mediator.Send(new GetProductRequest());
            return Ok(result);
        }
        catch(Exception ex)
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

    [HttpGet("categories")]
    public async Task<IActionResult> GetCategoriesAsync()
    {
        try
        {
            var result = await _mediator.Send(new GetCategories());

            return Ok(result);
        }catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        
    }
}
