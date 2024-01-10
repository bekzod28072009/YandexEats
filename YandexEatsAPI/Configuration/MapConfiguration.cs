using AutoMapper;
using YandexEats.Domain.Entities.Foods;
using YandexEats.Domain.Entities.Users;
using YandexEats.Service.Dto_s.FoodsDto;
using YandexEats.Service.Dto_s.UsersDto;

namespace YandexEatsAPI.Configuration
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Users, UsersDto>().ReverseMap();
        }
    }
}
