using System.Collections.Generic;

namespace DesafioToroInvestimentos.Domain.DTOs
{
    public class UserOutputDto
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public decimal BankBalance { get; set; }

        public decimal Amount { get{ return GetAmount(InvestimentAssets); } 
        }

        public IEnumerable<InvestmentAssetDto> InvestimentAssets { get; set; }

        private decimal GetAmount(IEnumerable<InvestmentAssetDto> investmentAsset)
        {
            decimal amount = 0.0M;

            foreach (var item in investmentAsset)
            {
                var value = item.Quantity * item.Value;
                amount += value;
            }

            return amount;
        }

    }

    public class InvestmentAssetDto
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Value { get; set; }
    }

}
