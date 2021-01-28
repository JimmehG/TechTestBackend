using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechTest.Domain;
using TechTest.Domain.PhotosAggregate;

namespace TechTest.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IPhotosRepository, PhotosRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<TechTestDbContext>(options => options.UseNpgsql(connectionString));
            return services;
        }
    }
}