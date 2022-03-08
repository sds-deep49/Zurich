using Microsoft.Extensions.DependencyInjection;
using System;
using Zurich.Common.Constants;
using Zurich.Domain.Interfaces.Services;

namespace Zurich.Services
{
    public static class DependencyInjectionServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddHttpClient<IUserServices, UserServices>(client =>
            {
                client.BaseAddress = new Uri(CommonConstants.GO_REST_BASE_URL);
            });
            return services;
        }
    }
}
