using CleanArchitectureCQRs.Application.Features.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitectureCQRs.Infrastructure.Identity;

public class AuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _configuration;

    public AuthService(UserManager<AppUser> userManager, IConfiguration config)
    {
        _userManager = userManager;
        _configuration = config;
    }

    public async Task<AppUser?> LoginUserAsync(string username, string password)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user is null) return null;

        var passwordCorrect = await _userManager.CheckPasswordAsync(user, password);
        if (!passwordCorrect) return null;

        return user;
    }

    public async Task<LoginDTO> Login(LoginDTO loginDTO)
    {
        var Result = await _userManager.FindByEmailAsync(loginDTO.Email);

        return new LoginDTO()
        {
            UserName = Result.UserName,
            Email = Result.Email,
            Token = TokenGenerator(loginDTO)
        };
    }

    public string TokenGenerator(LoginDTO loginDTO)
    {
        //payload using Claims 
        var Cliams = new List<Claim>
        {
            //Claim(claimType , value)
            new Claim(ClaimTypes.Name , loginDTO.UserName),
            new Claim(ClaimTypes.Email , loginDTO.Email)
        };
        //secret key 
        var TokenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]));

        //initialize register claims 
        var TokenGenerator = new JwtSecurityToken(
            //using passing by name 
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            expires: DateTime.UtcNow.AddHours(48),
            claims: Cliams,
            signingCredentials: new SigningCredentials(TokenKey, SecurityAlgorithms.HmacSha256)
            );
        var Token = new JwtSecurityTokenHandler().WriteToken(TokenGenerator);
        return Token;
    }

}
