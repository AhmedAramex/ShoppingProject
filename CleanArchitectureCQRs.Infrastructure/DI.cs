using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Identity;
using CleanArchitectureCQRs.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureCQRs.Infrastructure;

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


        //Add Authentications DI //userManager //SignInManager //RoleManager
        services.AddAuthentication();
        services.AddAuthorization();
        services.AddHttpContextAccessor();

        //Add Services Allow DI
        services.AddScoped<IAuthService, AuthService>();

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


        return services;
    }
}
