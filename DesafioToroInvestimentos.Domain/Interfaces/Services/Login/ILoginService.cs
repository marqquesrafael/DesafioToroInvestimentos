using DesafioToroInvestimentos.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Interfaces.Services.Login
{
    public interface ILoginService
    {
        TokenResponse Authenticate(string email, string password);
    }
}
