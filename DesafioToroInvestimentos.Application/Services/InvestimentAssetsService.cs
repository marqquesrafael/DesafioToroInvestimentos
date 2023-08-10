using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.InvestimentAssets;

namespace DesafioToroInvestimentos.Application.Services
{
    public class InvestimentAssetsService : BaseService<InvestimentAssetEntity>, IInvestimentAssetsService
    {
        public InvestimentAssetsService(IBaseRepository<InvestimentAssetEntity> repository) : base(repository)
        {
        }
    }
}
