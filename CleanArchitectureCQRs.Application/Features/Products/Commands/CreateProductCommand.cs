using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Dtos;
using CleanArchitectureCQRs.Domain.Entites;
using FluentValidation;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Products.Commands;

public class CreateProductCommand : IRequest<bool>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? Image { get; set; }
    public Guid? CategoryId { get; set; }
}

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Description).NotEmpty();
        RuleFor(p => p.Price).GreaterThan(0);
    }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
{
    private readonly IGenericRepository<Product> _productRepositroy;

    public CreateProductCommandHandler(IGenericRepository<Product> productRepositroy)
    {
        _productRepositroy = productRepositroy;
    }

    public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {

        await _productRepositroy.Add(new Product()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            CategoryId = (Guid)request.CategoryId,
        });

        await _productRepositroy.SaveAsync();

        return true;
    }
}
