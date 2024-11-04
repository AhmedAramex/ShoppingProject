namespace CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;

public class LoginResponseDTO
{
    public string UserName { get; set; }
    public string Token { get; set; }
    public string Errors { get; set; }
}
