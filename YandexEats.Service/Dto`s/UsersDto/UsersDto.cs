using YandexEats.Service.Dto_s.FoodsDto;

namespace YandexEats.Service.Dto_s.UsersDto
{
    public class UsersDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Addres { get; set; }

        public FoodDto Food { get; set; }
    }
}
