using DesafioToroInvestimentos.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Interfaces.Services.User
{
    public interface IUserService : IBaseService<UserEntity>
    {
        UserEntity GetUserByEmailAndPassword(string email, string password);

        IQueryable<UserEntity> GetAll();
    }
}
