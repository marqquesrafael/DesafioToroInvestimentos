using DesafioToroInvestimentos.Infrastructure.Persistence.Mapping;
using DesafioToroInvestimentos.Infrastructure.Persistence.Mapping.InvestimentAssets;
using DesafioToroInvestimentos.Infrastructure.Persistence.Mapping.User;
using Microsoft.EntityFrameworkCore;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Configuration
{
    public class ToroInvestimentosDbContext : DbContext
    {
        public ToroInvestimentosDbContext(DbContextOptions<ToroInvestimentosDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new InvestimentAssetsMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
