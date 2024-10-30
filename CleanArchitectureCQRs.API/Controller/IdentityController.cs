using CleanArchitectureCQRs.Application.Features.Dtos;
using CleanArchitectureCQRs.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controller;

public class UserController : BaseController
{

    private readonly UserManager<AppUser> _userManager;
    private readonly AuthService _authService;


    public UserController(UserManager<AppUser> userManager, AuthService authService)
    {
        _userManager = userManager;
        _authService = authService;
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

        var Result = _authService.Login(loginDTO);
        return Ok(Result);
        //if (!ModelState.IsValid)
        //    return BadRequest(ModelState);

        //var Result = await _userManager.FindByEmailAsync(loginDTO.Email);
        //if (Result is null) return Unauthorized();

        //return Ok(new
        //{
        //    userName = Result.UserName,
        //    Email = Result.Email,
        //    Token = _helpers.TokenGenerator(loginDTO)
        //});
    }

}
