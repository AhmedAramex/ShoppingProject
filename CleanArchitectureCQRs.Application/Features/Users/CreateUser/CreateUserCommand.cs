using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;
using CleanArchitectureCQRs.Application.Interfaces;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Users.CreateUser;

public class CreateUserCommand : IRequest<bool>
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}

public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IAuthService _authService;

    public CreateUserHandler(IAuthService authService)
    {
        _authService = authService;
    }
    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
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

        var Result = await _authService.RegisterUserAsync(user);
        if (Result is null) return false;

        return true;
    }
}
