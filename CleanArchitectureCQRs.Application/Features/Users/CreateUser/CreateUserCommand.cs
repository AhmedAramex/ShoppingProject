using CleanArchitectureCQRs.Domain.Common;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Users.CreateUser;

public class CreateUserCommand : IRequest<Result>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? PhoneNumber { get; set; }
}

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Result>
{
    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {

    }
}
