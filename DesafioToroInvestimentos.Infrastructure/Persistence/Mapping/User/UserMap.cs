using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Enums.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DesafioToroInvestimentos.Infrastructure.Persistence.Mapping.User
{
    public class UserMap : BaseMap<UserEntity>
    {
        public override string GetTableName() => "tb_user";

        public override void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.FullName)
                .HasColumnName("full_name")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("email")
                .IsRequired();

            builder.Property(p => p.Password)
                .HasColumnName("password")
                .IsRequired();

            builder.Property(p => p.CPF)
                .HasColumnName("cpf")
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasColumnName("phone_number")
                .IsRequired();

            builder.Property(p => p.Type)
                .HasColumnName("type")
                .HasConversion<string>()
                .IsRequired();

            builder.Property(p => p.BankBalance)
                .HasColumnName("balance")
                .HasPrecision(18, 2);

            builder.HasMany(p => p.InvestimentAssets)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            builder.HasData(
                new UserEntity("admin@toroinvestimentos.com", "1234", "Administrator", "111.111.111-01", "31 99999-9999", UserTypeEnum.Administrator, 100) { Id = 1, CreatedAt = DateTime.Now },
                new UserEntity("fernando@toroinvestimentos.com", "1234", "Fernando Souza", "222.222.222-02", "31 98888-8888", UserTypeEnum.Client, 150) { Id = 2, CreatedAt = DateTime.Now },
                new UserEntity("ricardo@toroinvestimentos.com", "1234", "Ricardo Giani", "333.333.333-03", "31 97777-7777", UserTypeEnum.Client, 250) { Id = 3, CreatedAt = DateTime.Now },
                new UserEntity("rafael@toroinvestimentos.com", "1234", "Rafael Marques", "444.444.444-04", "31 96666-6666", UserTypeEnum.Client, 300) { Id = 4, CreatedAt = DateTime.Now }
                );
        }
    }
}
