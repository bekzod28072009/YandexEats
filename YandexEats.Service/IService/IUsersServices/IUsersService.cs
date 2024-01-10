using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Entities.Users;
using YandexEats.Service.Dto_s.UsersDto;

namespace YandexEats.Service.IService.IUsersServices
{
    public interface IUsersService
    {
        IQueryable<Users> GetAll(Expression<Func<Users, bool>> expression, string[] includes = null);
        ValueTask<UsersDto> GetAsync(Expression<Func<Users, bool>> expression, string[] includes = null);
        ValueTask<UsersDto> CreateAsync(UsersDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<Users, bool>> expression);
        UsersDto Update(int id, UsersDto entity);
    }
}
