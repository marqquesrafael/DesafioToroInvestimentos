using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Exceptions;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.Login;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using DesafioToroInvestimentos.Domain.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioToroInvestimentos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;


        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

       
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                var token = _loginService.Authenticate(request.Email, request.Password);
                return Ok(token);
            }
            catch(InvalidCredentialsException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(503, ex.Message);
            }
        }

    }
}
