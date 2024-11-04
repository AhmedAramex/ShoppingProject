using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;

namespace CleanArchitectureCQRs.Application.Interfaces
{
    public interface IAuthService
    {
        string TokenGenerator(string UserName, string Email);
        Task<LoginDTO?> LoginUserAsync(string username, string password, string email);

        Task<object> RegisterUserAsync(RegisterationDTO registerationDTO);



    }
}