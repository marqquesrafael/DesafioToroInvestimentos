using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using DesafioToroInvestimentos.Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Entities.User
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(string email, string password, string fullName, string cPF, string phoneNumber, UserTypeEnum type, decimal bankBalance)
        {
            Email = email;
            Password = password;
            FullName = fullName;
            CPF = cPF;
            PhoneNumber = phoneNumber;
            Type = type;
            BankBalance = bankBalance;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string CPF { get; set; }

        public string PhoneNumber { get; set; }

        public UserTypeEnum Type { get; set; }

        public decimal BankBalance { get; set; }

        public virtual IList<InvestimentAssetEntity> InvestimentAssets { get; set; }
    }
}
