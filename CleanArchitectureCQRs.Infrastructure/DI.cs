using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureCQRs.Infrastructure;

public static class DI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("TestDBConnection")));
        services.AddDbContext<IdentityContext>(options => options.UseSqlServer(config.GetConnectionString("IdentityDBConnection")));

        return services;
    }
}
