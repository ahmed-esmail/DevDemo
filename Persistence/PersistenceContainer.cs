using Application.Contracts;
using DevDemo.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
  public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer("Server=.;Database=devExpress;Trusted_Connection=True;Encrypt=False"));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IProductRepository), typeof(PostRepository));

            return services;
        }
    }

}
