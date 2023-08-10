using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioToroInvestimentos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/user/{Id}"), Authorize]
        public IActionResult GetUser(long id)
        {
            var user = _userService.GetById(id);

            return Ok(user.FullName);
        }
    }
}
