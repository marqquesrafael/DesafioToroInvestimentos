using DesafioToroInvestimentos.Domain.Entities;
using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Mapping
{
    public abstract class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public abstract string GetTableName();


        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(GetTableName());

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CreatedAt).HasColumnName("created_at");
            builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
            builder.Property(p => p.Active).HasColumnName("active");

        }
    }
}
