using System;
using System.Linq.Expressions;
using eTickets.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Repos;

public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new()
{
    private readonly AppDbContext context;

    public BaseRepository(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = context.Set<T>();
        
        query = includes.Aggregate(query, (current, include) => current.Include(include));
        return await query.ToListAsync();
    }

    public Task<T?> GetById(int id)
    {
        return context.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
    }
    public async Task Add(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        await context.Set<T>().AddAsync(entity);

        await context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var restult = await GetById(id);
        if (restult == null)
            throw new ArgumentNullException(nameof(restult));
        
        context.Set<T>().Remove(restult);
        await context.SaveChangesAsync();
    }
}
