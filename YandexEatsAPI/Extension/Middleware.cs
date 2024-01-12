using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using YandexEats.Data.AppDBContexts;
using YandexEats.Data.IRepository;
using YandexEats.Data.Repository;
using YandexEats.Domain.Entities.Foods;
using YandexEats.Domain.Entities.Users;
using YandexEats.Service.IService.IFoodsServices;
using YandexEats.Service.IService.IUsersServices;
using YandexEats.Service.Service.FoodsService;
using YandexEats.Service.Service.UsersServices;

namespace YandexEatsAPI.Extension
{
    public static class Middleware
    {
        public static void AddDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }


        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<Food>, GenericRepository<Food>>();
            services.AddTransient<IGenericRepository<Users>, GenericRepository<Users>>();
        }

        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IFoodService, FoodService>();
        }
    }
}
