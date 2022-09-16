
using Dinnerhub.Application.Common.Interfaces.Authentication;
using Dinnerhub.Application.Common.Interfaces.Services;
using Dinnerhub.Infrastructure.Authentication;
using Dinnerhub.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dinnerhub.Infrastructure;


public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
         return services;
    }
}