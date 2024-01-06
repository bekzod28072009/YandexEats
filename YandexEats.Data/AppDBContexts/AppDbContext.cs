using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Entities.Foods;
using YandexEats.Domain.Entities.Users;

namespace YandexEats.Data.AppDBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
