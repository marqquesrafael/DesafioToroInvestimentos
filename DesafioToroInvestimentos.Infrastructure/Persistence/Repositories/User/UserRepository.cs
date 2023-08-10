using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Infrastructure.Persistence.Configuration;
using DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.User
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ToroInvestimentosDbContext toroInvestimentosDbContext) : base(toroInvestimentosDbContext)
        {
        }

        public UserEntity GetUserByEmailAndPassword(string email, string password) 
        {
            var user = Select()
                .Where(p =>
                       p.Email == email && 
                       p.Password == password)
                .FirstOrDefault();

            return user;
        } 
    }
}
