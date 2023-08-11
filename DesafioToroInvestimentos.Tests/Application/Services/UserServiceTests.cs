using AutoFixture;
using AutoMapper;
using DesafioToroInvestimentos.Application.Services;
using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Exceptions;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using Moq;
using Xunit;

namespace DesafioToroInvestimentos.Tests.Application.Services
{
    public class UserServiceTests
    {
        private Mock<IUserRepository> _userRepository;
        private readonly Mock<IMapper> _mapper;

        private IUserService _userService;

        public UserServiceTests()
        {
            _userRepository = new Mock<IUserRepository>();
            _mapper = new Mock<IMapper>();

            _userService = new UserService(_userRepository.Object, _mapper.Object);
        }


        [Fact(DisplayName = "Insert With Id Error")]
        public void Insert_With_Id()
        {
            Fixture fixture = new Fixture();

            var user = fixture.Build<UserEntity>()
                .Without(p => p.InvestimentAssets)
                .Create();

            InsertEntityWithIdException exception = Assert.Throws<InsertEntityWithIdException>(() => _userService.Create(user));
            Assert.Equal("Erro ao inserir registro, Não é possível inserir um registro com Id pré definido", exception.Message);
        }

        [Fact(DisplayName = "Insert Succesfully")]
        public void Insert_Succefully()
        {
            long userIdExpected = 1;

            var fixture = new Fixture();
            var user = fixture.Build<UserEntity>()
                .With(p => p.Id, 0)
                .Without(p => p.InvestimentAssets)
                .Create();

            _userRepository.Setup(s => s.Insert(user))
                .Callback<UserEntity>(
                (user) =>
                {
                    user.Id = userIdExpected;
                    Assert.Equal(userIdExpected, user.Id);
                });

        }

    }
}
