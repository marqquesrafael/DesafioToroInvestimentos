using DesafioToroInvestimentos.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        UserEntity GetUserByEmailAndPassword(string email, string password);
    }
}
