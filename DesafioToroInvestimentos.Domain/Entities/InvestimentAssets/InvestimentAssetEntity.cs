using DesafioToroInvestimentos.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Domain.Entities.InvestimentAssets
{
    public class InvestimentAssetEntity : BaseEntity
    {
        public InvestimentAssetEntity(string name, int quantity, decimal value, long userId)
        {
            Name = name;
            Quantity = quantity;
            Value = value;
            UserId = userId;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Value { get; set; }

        public long UserId { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
