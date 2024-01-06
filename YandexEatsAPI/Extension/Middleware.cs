using Microsoft.EntityFrameworkCore;
using YandexEats.Data.AppDBContexts;

namespace YandexEatsAPI.Extension
{
    public static class Middleware
    {
        public static void AddDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
