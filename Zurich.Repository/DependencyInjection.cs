using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zurich.Common.Constants;
using Zurich.Domain.Interfaces;
using Zurich.Repository.DataLayer;

namespace Zurich.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ICoursesRepository, CoursesRepository>();
            services.AddTransient<ITrainingsRepository, TrainingsRepository>();
            services.AddTransient<ISubscriptionRepository, SubscriptionRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ZurichDbContext>(opt => opt
                .UseSqlServer(CommonConstants.CONNECTION_STRING).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            
            return services;
        }
    }
}