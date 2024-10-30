using CleanArchitectureCQRs.Application.Features.Dtos;
using CleanArchitectureCQRs.Application.HelpersClass;
using CleanArchitectureCQRs.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controller;

public class UserController : BaseController
{

    private readonly UserManager<AppUser> _userManager;
    private readonly HelpersClass _helpers;


    public UserController(UserManager<AppUser> userManager, HelpersClass helpers)
    {
        _userManager = userManager;
        _helpers = helpers;
    }

    [HttpPost]
    [Route("Registeration")]
    public async Task<IActionResult> Registeration(RegisterationDTO registerationDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = new AppUser
        {
            UserName = registerationDTO.UserName,
            PhoneNumber = registerationDTO.phoneNumber,
            Email = registerationDTO.email,
        };

        var Result = await _userManager.CreateAsync(user, registerationDTO.UserName);

        if (!Result.Succeeded) return BadRequest(Result.Errors);

        return Ok(Result);
    }

    [HttpPost]
    [Route("Login")]
    public async Task<IActionResult> Login(LoginDTO loginDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var Result = await _userManager.FindByEmailAsync(loginDTO.Email);
        if (Result is null) return Unauthorized();

        return Ok(new
        {
            userName = Result.UserName,
            Email = Result.Email,
            Token = _helpers.TokenGenerator(loginDTO)
        });
    }

}
