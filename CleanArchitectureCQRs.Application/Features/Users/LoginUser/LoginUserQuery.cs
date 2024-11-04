using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;
using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Common;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Users.LoginUser;

public class LoginUserQuery : IRequest<Result<LoginResponseDTO>>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
}

public class LogInUserHandler : IRequestHandler<LoginUserQuery, Result<LoginResponseDTO>>
{
    private readonly IAuthService _authService;

    public LogInUserHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<Result<LoginResponseDTO>> Handle(LoginUserQuery request, CancellationToken cancellationToken)
    {
        var result = await _authService.LoginUserAsync(request.Username, request.Password, request.Email);

        if (result is null)
        {
            return Result<LoginResponseDTO>.Failed(new Error("UserName or Password Is not Correct"));
        }

        return Result<LoginResponseDTO>.Success(new LoginResponseDTO
        {
            UserName = result.UserName ?? "",
            Token = result.Token ?? ""
        });

    }
}
