using System;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class ActorService : IActorService
{
    private readonly AppDbContext context;

    public ActorService(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<Actor>> GetAll()
    {
        return await context.Actors.ToListAsync();
    }

    public Task<Actor?> GetById(int id)
    {
        return context.Actors.FirstOrDefaultAsync(a => a.Id == id);
    }

    public Task Add(Actor actor)
    {
        context.Actors.Add(actor);
        return context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var actor = await GetById(id);
        if (actor != null)
        {
            context.Actors.Remove(actor);
            await context.SaveChangesAsync();
        }
    }

    public Task Update(Actor actor)
    {
        context.Actors.Update(actor);
        return context.SaveChangesAsync();
    }
}
