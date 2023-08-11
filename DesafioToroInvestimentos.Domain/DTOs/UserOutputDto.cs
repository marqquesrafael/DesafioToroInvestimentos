using System.Collections.Generic;

namespace DesafioToroInvestimentos.Domain.DTOs
{
    public class UserOutputDto
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public decimal BankBalance { get; set; }

        public IEnumerable<InvestmentAssetDto> InvestimentAssets { get; set; }
    }

    public class InvestmentAssetDto
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Value { get; set; }

        public long UserId { get; set; }
    }

}
