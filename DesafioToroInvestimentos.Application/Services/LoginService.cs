using DesafioToroInvestimentos.Domain.Exceptions;
using DesafioToroInvestimentos.Domain.Interfaces.Services.JWT;
using DesafioToroInvestimentos.Domain.Interfaces.Services.Login;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using DesafioToroInvestimentos.Domain.Responses;

namespace DesafioToroInvestimentos.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserService _userService;
        private readonly IJwtProvider _jwtProvider;

        public LoginService(IUserService userService, IJwtProvider jwtProvider)
        {
            _userService = userService;
            _jwtProvider = jwtProvider;
        }

        public TokenResponse Authenticate(string email, string password)
        {
            var user = _userService.GetUserByEmailAndPassword(email, password);

            if (user is null)
                throw new InvalidCredentialsException();

            TokenResponse token = _jwtProvider.Generate(user);

            return token;
        }

    }
}
