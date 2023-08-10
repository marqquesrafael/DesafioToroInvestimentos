using AutoFixture;
using DesafioToroInvestimentos.Application.Services;
using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Exceptions;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.JWT;
using DesafioToroInvestimentos.Domain.Interfaces.Services.Login;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using DesafioToroInvestimentos.Domain.Responses;
using Moq;
using Xunit;

namespace DesafioToroInvestimentos.Tests.Application.Services
{
    public class LoginServiceTests
    {
        private readonly Mock<IUserRepository> _userRepository;
        private readonly IUserService _userService;
        private readonly Mock<IJwtProvider> _jwtProvider;

        private readonly ILoginService _loginService;

        public LoginServiceTests()
        {
            _userRepository = new Mock<IUserRepository>();
            _jwtProvider = new Mock<IJwtProvider>();

            _userService = new UserService(_userRepository.Object);

            _loginService = new LoginService(_userService, _jwtProvider.Object);
        }

        [Fact(DisplayName = "Authenticate Succefully")]
        public void Authenticate_Succefully()
        {
            var emailExpected = "rafael@toroinvestimentos.com";
            var passwordExpected = "1234";

            var fixture = new Fixture();

            var user = fixture.Build<UserEntity>()
                .With(p => p.Email, emailExpected)
                .With(p => p.Password, passwordExpected)
                .Without(p => p.InvestimentAssets)
                .Create();

            var tokenResponse = fixture.Build<TokenResponse>().Create();

            _userRepository.Setup(s => s.GetUserByEmailAndPassword(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(user);

            _jwtProvider.Setup(s => s.Generate(It.IsAny<UserEntity>()))
                .Returns(tokenResponse);

           var token = _loginService.Authenticate(emailExpected, passwordExpected);

            Assert.Equal(tokenResponse.Token, token.Token);
            Assert.Equal(tokenResponse.TokenType, token.TokenType);
            Assert.Equal(tokenResponse.ExpireIn, token.ExpireIn);

            Assert.Equal(user.Email, emailExpected);
            Assert.Equal(user.Password, passwordExpected);
        }

        [Fact(DisplayName = "Authenticate with invalid credentials")]
        public void Login_With_Invalid_Credentials()
        {
            var email = "rafael@toroinvestimentos.com";
            var password = "1234";

            _userRepository.Setup(s => s.GetUserByEmailAndPassword(It.IsAny<string>(), It.IsAny<string>()));

            var exception = Assert.Throws<InvalidCredentialsException>(() => _loginService.Authenticate(email, password));

            Assert.Equal("Falha no login, credenciais inválidas", exception.Message);

        }

    }
}
