using AutoMapper;
using DesafioToroInvestimentos.Application.Services;
using DesafioToroInvestimentos.Domain.DTOs;
using DesafioToroInvestimentos.Domain.Entities.InvestimentAssets;
using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Interfaces.Services.Login;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioToroInvestimentos.Application
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddServicesResolvers(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserService, UserService>();


            services.AddSingleton(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserEntity, UserOutputDto>();
                cfg.CreateMap<InvestimentAssetEntity, InvestmentAssetDto>();

            }).CreateMapper());

            return services;
        }
    }
}
