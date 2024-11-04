using CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;
using CleanArchitectureCQRs.Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitectureCQRs.Infrastructure.Identity;

public class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _configuration;

    public AuthService(UserManager<AppUser> userManager, IConfiguration config)
    {
        _userManager = userManager;
        _configuration = config;
    }

    public async Task<LoginDTO?> LoginUserAsync(string username, string password, string email)
    {
        try
        {

            var user = await _userManager.FindByNameAsync(username);
            if (user is null) return null;

            var passwordCorrect = await _userManager.CheckPasswordAsync(user, password);
            if (!passwordCorrect) return null;

            var UserData = new LoginDTO
            {
                UserName = user?.UserName ?? "",
                Email = user?.Email ?? "",
                Token = TokenGenerator(username, email)
            };
            return UserData;
        }
        catch (Exception ex)
        {
            var UserData = new LoginDTO
            {
                Errors = ex.Message
            };
            return UserData;
        }

    }

    public async Task<object> RegisterUserAsync(RegisterationDTO registerationDTO)
    {
        try
        {

            var user = new AppUser
            {
                UserName = registerationDTO.UserName,
                PhoneNumber = registerationDTO.PhoneNumber,
                Email = registerationDTO.Email,
                FirstName = registerationDTO.FirstName,
                LastName = registerationDTO.LastName,
            };

            var Result = await _userManager.CreateAsync(user, registerationDTO.Password);

            if (!Result.Succeeded)
            {
                var Error = Result.Errors.Select(e => e.Description).ToList();
            }

            return Result;
        }
        catch (TaskCanceledException ex)
        {
            return ex;
        }

    }

    public string TokenGenerator(string UserName, string Email)
    {
        //payload using Claims 
        var Cliams = new List<Claim>
        {
            //Claim(claimType , value)
            new Claim(ClaimTypes.Name , UserName),
            new Claim(ClaimTypes.Email , Email)
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
