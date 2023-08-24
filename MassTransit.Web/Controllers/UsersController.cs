using MassTransit.Web.Models;
using MassTransit.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace MassTransit.Web.Controllers;

[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateUser([FromBody] User user, CancellationToken token)
    {
        await _userService.CreateUser(user, token);
        return Ok();
    }
}