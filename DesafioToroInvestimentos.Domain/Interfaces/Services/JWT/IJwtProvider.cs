using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Interfaces.Services.JWT
{
    public interface IJwtProvider
    {
        TokenResponse Generate(UserEntity user);
    }
}
