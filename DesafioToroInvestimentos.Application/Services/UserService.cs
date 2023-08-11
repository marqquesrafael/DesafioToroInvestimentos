using AutoMapper;
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
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper) : base(repository)
        {
            _userRepository = repository;
            _mapper = mapper;
        }

        public TOut GetById<TOut>(long id)
        {
            var user = _userRepository.GetById(id);

            var output = _mapper.Map<TOut>(user);

            return output;
        }

        public UserEntity GetUserByEmailAndPassword(string email, string password)
        {
            return _userRepository.GetUserByEmailAndPassword(email, password);
        }
    }
}
