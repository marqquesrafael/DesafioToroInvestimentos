using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Infrastructure.Persistence.Configuration;
using DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.Base;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.InvestimentAssets
{
    public class InvestimentAssetsRepository : BaseRepository<InvestimentAssetEntity>, IInvestimentAssetsRepository
    {
        public InvestimentAssetsRepository(ToroInvestimentosDbContext toroInvestimentosDbContext) : base(toroInvestimentosDbContext)
        {
        }
    }
}
