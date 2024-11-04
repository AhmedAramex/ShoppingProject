namespace CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;


public class LoginDTO
{
    public string? UserName { get; set; }

    public string? Password { get; set; }
    public string? Email { get; set; }

    public string? Token { get; set; }
    public string? Errors { get; set; }
}
