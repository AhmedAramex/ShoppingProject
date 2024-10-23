using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Identity;
using CleanArchitectureCQRs.Infrastructure.Repositories;
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

        services.AddIdentityCore<AppUser>().AddEntityFrameworkStores<IdentityContext>();
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
