using Data;
using Data.Entities.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BCrypt.Net;
using learning_platform_back.Services;


[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IAccountsService accountsService;

    public UserController(IAccountsService accountsService)
    {
        this.accountsService = accountsService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto model)
    {
        await accountsService.Register(model);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto model)
    {
        await accountsService.Login(model);
        // to return 
        return Ok();
        //return Ok(await accountsService.Login(model));
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await accountsService.Logout();
        return Ok();
    }

}
