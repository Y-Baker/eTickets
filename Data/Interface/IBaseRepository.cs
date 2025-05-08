using System;

namespace eTickets.Data.Interface;

public interface IBaseRepository<T> where T : class, IEntityBase, new()
{
    Task<IEnumerable<T>> GetAll();
    Task<T?> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
}