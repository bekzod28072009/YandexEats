using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Data.IRepository;
using YandexEats.Domain.Entities.Foods;
using YandexEats.Domain.Entities.Users;
using YandexEats.Service.Dto_s.FoodsDto;
using YandexEats.Service.Dto_s.UsersDto;
using YandexEats.Service.IService.IFoodsServices;

namespace YandexEats.Service.Service.FoodsService
{
    public class FoodService : IFoodService
    {
        private readonly IGenericRepository<Food> repository;
        private readonly IMapper mapper;
        public FoodService(IGenericRepository<Food> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<FoodDto> CreateAsync(FoodDto entity)
        {
            var food = new Food();
            if (entity is not null)
            {
                var newFood = mapper.Map<Food>(entity);
                food = await repository.CreateAsync(newFood);
            }
            repository.SaveChangesAsync();
            return mapper.Map<FoodDto>(food);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<Food, bool>> expression)
        {
            bool result = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return result;
        }

        public IQueryable<Food> GetAll(Expression<Func<Food, bool>> expression, string[] includes = null)
            => repository.GetAll(expression, includes);

        public async ValueTask<FoodDto> GetAsync(Expression<Func<Food, bool>> expression, string[] includes = null)
        {
            var food = await repository.GetAsync(expression, includes);
            return mapper.Map<FoodDto>(food);
        }

        public FoodDto Update(int id, FoodDto entity)
        {
            var food = mapper.Map<Food>(entity);
            food.Id = id;
            var newFood = repository.Update(food);
            return mapper.Map<FoodDto>(newFood);
        }
    }
}
