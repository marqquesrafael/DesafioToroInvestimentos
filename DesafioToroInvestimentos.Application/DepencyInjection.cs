using DesafioToroInvestimentos.Application.Services;
using DesafioToroInvestimentos.Domain.Entities;
using DesafioToroInvestimentos.Domain.Interfaces.Services;
using DesafioToroInvestimentos.Domain.Interfaces.Services.Login;
using DesafioToroInvestimentos.Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioToroInvestimentos.Application
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddServicesResolvers(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
