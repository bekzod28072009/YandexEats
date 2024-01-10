using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Entities.Foods;
using YandexEats.Service.Dto_s.FoodsDto;

namespace YandexEats.Service.IService.IFoodsServices
{
    public interface IFoodService
    {
        IQueryable<Food> GetAll(Expression<Func<Food, bool>> expression, string[] includes = null);
        ValueTask<FoodDto> GetAsync(Expression<Func<Food, bool>> expression, string[] includes = null);
        ValueTask<FoodDto> CreateAsync(FoodDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<Food, bool>> expression);
        FoodDto Update(int id, FoodDto entity);
    }
}
