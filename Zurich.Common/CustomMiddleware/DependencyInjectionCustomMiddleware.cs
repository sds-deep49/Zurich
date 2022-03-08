using Microsoft.AspNetCore.Builder;

namespace Zurich.Common.CustomMiddleware
{
    public static class DependencyInjectionCustomMiddleware
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}