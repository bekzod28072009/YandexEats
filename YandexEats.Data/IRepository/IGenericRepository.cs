using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Commons;

namespace YandexEats.Data.IRepository
{
    public interface IGenericRepository<T> where T : Auditable
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null);
        ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);
        ValueTask<T> CreateAsync(T entity);
        ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        T Update(T entity);
        public ValueTask SaveChangesAsync();
    }
}
