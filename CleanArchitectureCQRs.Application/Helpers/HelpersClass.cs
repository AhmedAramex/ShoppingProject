using CleanArchitectureCQRs.Application.Features.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitectureCQRs.Application.HelpersClass;

public class HelpersClass
{
    private readonly IConfiguration _configuration;

    public HelpersClass(IConfiguration configuration)
    {
        _configuration = configuration;
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
