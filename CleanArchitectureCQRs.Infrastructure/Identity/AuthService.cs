using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace CleanArchitectureCQRs.Infrastructure.Identity;

public class AuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _config;

    public AuthService(UserManager<AppUser> userManager, IConfiguration config)
    {
        _userManager = userManager;
        _config = config;
    }

    public async Task<AppUser?> LoginUserAsync(string username, string password)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user is null) return null;

        var passwordCorrect = await _userManager.CheckPasswordAsync(user, password);
        if (!passwordCorrect) return null;

        return user;
    }

    public async Task<string> GenerateTokenAsync(AppUser user)
    {
        //var token = ;

        return "";
    }
}
