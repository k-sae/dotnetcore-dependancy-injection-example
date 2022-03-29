using DependencyInjectionDemoApi.Domain.User;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    // GET
    private IUser _user;

    public UserController(IUser user)
    {
        _user = user;
    }

    [HttpGet(Name = "getUser")]
    public User Index()
    {
        return _user.GetUserWithCourseName();
    }
}