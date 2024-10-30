using CleanArchitectureCQRs.Application.HelpersClass;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Identity;
using CleanArchitectureCQRs.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CleanArchitectureCQRs.Infrastructure;

public static class DI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("TestDBConnection")));
        services.AddDbContext<IdentityContext>(options => options.UseSqlServer(config.GetConnectionString("IdentityDBConnection")));

        //services.AddIdentityCore<AppUser>().AddEntityFrameworkStores<IdentityContext>();


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
        .AddDefaultTokenProviders();

        services.AddAuthentication();
        services.AddAuthorization();
        services.AddSingleton<HelpersClass>();
        //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opts => opts.TokenValidationParameters = new TokenValidationParameters()
        //{
        //    ValidateIssuer = true,
        //    ValidateAudience = true,
        //    ValidateLifetime = true,
        //    ValidateIssuerSigningKey = true,
        //    ValidIssuer = config["Jwt:Issuer"],
        //    ValidAudience = config["Jwt:Audience"],
        //    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]))
        //});

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


        return services;
    }
}
