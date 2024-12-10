using CleanArchitectureCQRs.Application.Features.Users.CreateUser;
using CleanArchitectureCQRs.Application.Features.Users.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controller;

public class UserController : BaseController
{

    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("Registeration")]
    public async Task<IActionResult> Registeration(CreateUserCommand createUserCommand)
    {
        var result = await _mediator.Send(createUserCommand);
        if (!result.Succeed) return BadRequest("error Registeration");
        return Ok(result);
    }

    [HttpPost]
    [Route("Login")]
    public async Task<IActionResult> Login(LoginUserQuery loginUserQuery)
    {
        try
        {
            var Result = await _mediator.Send(loginUserQuery);

            return Ok(Result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
            throw (ex);
        }
    }


}
