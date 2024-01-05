using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Commons;

namespace YandexEats.Domain.Entities.Foods
{
    public class Food : Auditable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Payment { get; set; }
    }
}
