using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRs.API.Controller;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase
{
}
