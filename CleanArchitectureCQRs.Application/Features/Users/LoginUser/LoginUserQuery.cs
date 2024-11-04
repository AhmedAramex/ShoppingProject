using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;
using CleanArchitectureCQRs.Application.Interfaces;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Users.LoginUser;

public class LoginUserQuery : IRequest<LoginResponseDTO>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
}

public class LogInUserHandler : IRequestHandler<LoginUserQuery, LoginResponseDTO>
{
    private readonly IAuthService _authService;

    public LogInUserHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<LoginResponseDTO> Handle(LoginUserQuery request, CancellationToken cancellationToken)
    {
        var Result = await _authService.LoginUserAsync(request.Username, request.Password, request.Email);


        if (Result is null)
        {
            return new LoginResponseDTO
            {
                Errors = "UserName or Password Is not Correct",
            };
        }

        var UserData = new LoginResponseDTO
        {
            UserName = Result.UserName,
            Token = Result.Token
        };
        return UserData;

    }
}
