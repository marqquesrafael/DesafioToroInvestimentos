using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using DesafioToroInvestimentos.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Mapping.InvestimentAssets
{
    public class InvestimentAssetsMap : BaseMap<InvestimentAssetEntity>
    {
        public override string GetTableName() => "tb_investiment_asset";

        public override void Configure(EntityTypeBuilder<InvestimentAssetEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(p => p.Value)
                .HasColumnName("value")
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(p => p.Quantity)
                .HasColumnName("quantity")
                .IsRequired();

            builder.Property(p => p.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.HasData(
                new InvestimentAssetEntity("PETR4", 10, 28.44M, 2) { Id = 1, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("SANB11", 4, 40.77M, 2) { Id = 2, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("MGLU3", 12, 25.91M, 2) { Id = 3, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("VVAR3", 2, 25.91M, 2) { Id = 4, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("TORO4", 25, 115.91M, 2) { Id = 5, CreatedAt = DateTime.Now },

                new InvestimentAssetEntity("PETR4", 5, 28.44M, 3) { Id = 6, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("SANB11", 9, 40.77M, 3) { Id = 7, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("MGLU3", 12, 25.91M, 3) { Id = 8, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("VVAR3", 1, 25.91M, 3) { Id = 9, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("TORO4", 18, 115.91M, 3) { Id = 10, CreatedAt = DateTime.Now },

                new InvestimentAssetEntity("PETR4", 14, 28.44M, 4) { Id = 11, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("SANB11", 9, 40.77M, 4) { Id = 12, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("MGLU3", 13, 25.91M, 4) { Id = 13, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("VVAR3", 7, 25.91M, 4) { Id = 14, CreatedAt = DateTime.Now },
                new InvestimentAssetEntity("TORO4", 22, 115.91M, 4) { Id = 15, CreatedAt = DateTime.Now }
                );
        }
    }
}
