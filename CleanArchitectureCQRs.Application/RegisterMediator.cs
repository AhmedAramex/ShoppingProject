using CleanArchitectureCQRs.Application.IReposatories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Application;

public static class RegisterMediator
{
    public static IServiceCollection Addmediator(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(RegisterMediator).Assembly));

        return services;

    }

}
