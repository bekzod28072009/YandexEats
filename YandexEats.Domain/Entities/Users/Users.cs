using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Commons;
using YandexEats.Domain.Entities.Foods;

namespace YandexEats.Domain.Entities.Users
{
    public class Users : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Addres { get; set; }

        public Food Food { get; set; }
    }
}
