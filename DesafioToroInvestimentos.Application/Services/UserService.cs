using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Application.Services
{
    public class UserService : BaseService<UserEntity>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository) : base(repository)
        {
            _userRepository = repository;
        }

        public IQueryable<UserEntity> GetAll()
        {
            return _userRepository.Select();
        }

        public UserEntity GetUserByEmailAndPassword(string email, string password)
        {
            return _userRepository.GetUserByEmailAndPassword(email, password);
        }
    }
}
