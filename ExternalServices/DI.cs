using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Identity;
using CleanArchitectureCQRs.Infrastructure.Repositories;
using ExternalServices.AuthenticationService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace ExternalServices
{
    public static class DI
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            //Add DBContexts DI
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("TestDBConnection")));
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(config.GetConnectionString("IdentityDBConnection")));

            //Add Identity DI
            services.AddIdentityCore<AppUser>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 0;
            })
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders()
            .AddRoles<IdentityContext>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = config["Jwt:Issuer"],
                    ValidAudience = config["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"])),
                };
            });

            services.AddHttpContextAccessor();

            //Add Services Allow DI
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
