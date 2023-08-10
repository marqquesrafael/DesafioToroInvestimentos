﻿// <auto-generated />
using System;
using DesafioToroInvestimentos.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioToroInvestimentos.WebAPI.Migrations
{
    [DbContext(typeof(ToroInvestimentosDbContext))]
    [Migration("20230810084346_userAssets")]
    partial class userAssets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioToroInvestimentos.Domain.Entities.InvestimentAssets.InvestimentAssetEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<decimal>("Value")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("tb_investiment_asset", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9841),
                            Name = "PETR4",
                            Quantity = 10,
                            UserId = 2L,
                            Value = 28.44m
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9843),
                            Name = "SANB11",
                            Quantity = 4,
                            UserId = 2L,
                            Value = 40.77m
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9844),
                            Name = "MGLU3",
                            Quantity = 12,
                            UserId = 2L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9844),
                            Name = "VVAR3",
                            Quantity = 2,
                            UserId = 2L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 5L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9845),
                            Name = "TORO4",
                            Quantity = 25,
                            UserId = 2L,
                            Value = 115.91m
                        },
                        new
                        {
                            Id = 6L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9846),
                            Name = "PETR4",
                            Quantity = 5,
                            UserId = 3L,
                            Value = 28.44m
                        },
                        new
                        {
                            Id = 7L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9847),
                            Name = "SANB11",
                            Quantity = 9,
                            UserId = 3L,
                            Value = 40.77m
                        },
                        new
                        {
                            Id = 8L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9847),
                            Name = "MGLU3",
                            Quantity = 12,
                            UserId = 3L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 9L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9848),
                            Name = "VVAR3",
                            Quantity = 1,
                            UserId = 3L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 10L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9849),
                            Name = "TORO4",
                            Quantity = 18,
                            UserId = 3L,
                            Value = 115.91m
                        },
                        new
                        {
                            Id = 11L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9849),
                            Name = "PETR4",
                            Quantity = 14,
                            UserId = 4L,
                            Value = 28.44m
                        },
                        new
                        {
                            Id = 12L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9850),
                            Name = "SANB11",
                            Quantity = 9,
                            UserId = 4L,
                            Value = 40.77m
                        },
                        new
                        {
                            Id = 13L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9851),
                            Name = "MGLU3",
                            Quantity = 13,
                            UserId = 4L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 14L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9852),
                            Name = "VVAR3",
                            Quantity = 7,
                            UserId = 4L,
                            Value = 25.91m
                        },
                        new
                        {
                            Id = 15L,
                            Active = true,
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9852),
                            Name = "TORO4",
                            Quantity = 22,
                            UserId = 4L,
                            Value = 115.91m
                        });
                });

            modelBuilder.Entity("DesafioToroInvestimentos.Domain.Entities.User.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<decimal>("BankBalance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("balance");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("tb_user", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = true,
                            BankBalance = 100m,
                            CPF = "111.111.111-01",
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8880),
                            Email = "admin@toroinvestimentos.com",
                            FullName = "Administrator",
                            Password = "1234",
                            PhoneNumber = "31 99999-9999",
                            Type = "Administrator"
                        },
                        new
                        {
                            Id = 2L,
                            Active = true,
                            BankBalance = 150m,
                            CPF = "222.222.222-02",
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8893),
                            Email = "fernando@toroinvestimentos.com",
                            FullName = "Fernando Souza",
                            Password = "1234",
                            PhoneNumber = "31 98888-8888",
                            Type = "Client"
                        },
                        new
                        {
                            Id = 3L,
                            Active = true,
                            BankBalance = 250m,
                            CPF = "333.333.333-03",
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8894),
                            Email = "ricardo@toroinvestimentos.com",
                            FullName = "Ricardo Giani",
                            Password = "1234",
                            PhoneNumber = "31 97777-7777",
                            Type = "Client"
                        },
                        new
                        {
                            Id = 4L,
                            Active = true,
                            BankBalance = 300m,
                            CPF = "444.444.444-04",
                            CreatedAt = new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8895),
                            Email = "rafael@toroinvestimentos.com",
                            FullName = "Rafael Marques",
                            Password = "1234",
                            PhoneNumber = "31 96666-6666",
                            Type = "Client"
                        });
                });

            modelBuilder.Entity("DesafioToroInvestimentos.Domain.Entities.InvestimentAssets.InvestimentAssetEntity", b =>
                {
                    b.HasOne("DesafioToroInvestimentos.Domain.Entities.User.UserEntity", "User")
                        .WithMany("InvestimentAssets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DesafioToroInvestimentos.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("InvestimentAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
