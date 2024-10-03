using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureCQRs.Application;

public static class DI
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(DI).Assembly));

        return services;
    }
}
