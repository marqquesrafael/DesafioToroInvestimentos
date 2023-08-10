using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Responses
{
    public class TokenResponse
    {
        public TokenResponse()
        {
            TokenType = "Bearer";
        }

        public string Token { get; set; }

        public string TokenType { get; set; }

        public int ExpireIn { get; set; }
    }
}
