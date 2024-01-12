using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YandexEats.Service.Dto_s.FoodsDto;
using YandexEats.Service.Dto_s.UsersDto;
using YandexEats.Service.IService.IFoodsServices;

namespace YandexEatsAPI.Controllers.FoodsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService service;
        public FoodController(IFoodService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(FoodDto dto)
             => Ok(await service.CreateAsync(dto));




        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
            => Ok(service.GetAll(p => p.Id != 0));





        [HttpPut("{id}")]
        public async ValueTask<IActionResult> UpdateAsync([FromRoute] int id, FoodDto dto)
            => Ok(service.Update(id, dto));



        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetAsync([FromRoute] int id)
            => Ok(await service.GetAsync(u => u.Id == id));



        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute] int id)
            => Ok(await service.DeleteAsync(p => p.Id == id));
    }
}
