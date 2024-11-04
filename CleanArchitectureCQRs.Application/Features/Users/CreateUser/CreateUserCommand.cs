using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;
using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Common;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Users.CreateUser;

public class CreateUserCommand : IRequest<Result>
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Result>
{
    private readonly IAuthService _authService;

    public CreateUserHandler(IAuthService authService)
    {
        _authService = authService;
    }
    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new RegisterationDTO
        {
            UserName = request.UserName,
            Password = request.Password,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber ?? "",
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        var result = await _authService.RegisterUserAsync(user);

        return result;
    }
}
