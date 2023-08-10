using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Configuration.JWT
{
    public class JWTConfiguration
    {
        public string Secret { get; set; }

        public int ExpirationInHour { get; set; }

        public string EmitedBy { get; set; }

        public string ValidatedIn { get; set; }

    }
}
