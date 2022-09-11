
using Dinnerhub.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Dinnerhub.Application;


public static class DependencyInjection 
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
         services.AddScoped<IAuthenticationService, AuthenticationService>();
         return services;
    }
}