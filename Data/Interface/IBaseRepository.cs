using System;
using System.Linq.Expressions;

namespace eTickets.Data.Interface;

public interface IBaseRepository<T> where T : class, IEntityBase, new()
{
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includes);
    Task<T?> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
}