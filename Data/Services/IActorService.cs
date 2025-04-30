using System;
using eTickets.Models;

namespace eTickets.Data.Services;

public interface IActorService
{
    Task<IEnumerable<Actor>> GetAll();

    Task<Actor?> GetById(int id);

    Task Add(Actor actor);

    Task Update(Actor actor);
    
    Task Delete(int id);
}
