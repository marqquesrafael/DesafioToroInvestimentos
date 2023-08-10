using DesafioToroInvestimentos.Domain.Configuration.JWT;
using DesafioToroInvestimentos.Domain.Interfaces.Repositories;
using DesafioToroInvestimentos.Domain.Interfaces.Services.JWT;
using DesafioToroInvestimentos.Infrastructure.Authentication;
using DesafioToroInvestimentos.Infrastructure.Persistence.Configuration;
using DesafioToroInvestimentos.Infrastructure.Persistence.Repositories.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DesafioToroInvestimentos.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceConfiguration(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ToroInvestimentosDbContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("DesafioToroInvestimentos.WebAPI"));
            });

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtConfiguration = configuration.GetSection("JWT");
            services.Configure<JWTConfiguration>(jwtConfiguration);

            services.AddScoped<IJwtProvider, JwtProvider>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new()
                {
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtConfiguration.GetSection("EmitedBy").Value,
                    ValidAudience = jwtConfiguration.GetSection("ValidatedIn").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfiguration.GetSection("Secret").Value))
                });

            return services;
        }
    }
}
